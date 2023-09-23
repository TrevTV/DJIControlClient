using DJIControlClient.Exceptions;
using System.Net.Http.Json;

namespace DJIControlClient
{
    public class Drone
    {
        /// <summary>
        ///  If true, Drone will throw exceptions. If false, it will only return false.
        ///  This does not include NotConnectedException
        /// </summary>
        public bool ThrowErrors { get; set; }

        private HttpClient _httpClient;

        public Drone(string ipPort)
        {
            if (!ipPort.EndsWith('/'))
                ipPort += '/';

            ipPort = "http://" + ipPort;

            _httpClient = new()
            {
                BaseAddress = new Uri(ipPort)
            };
        }

        public async Task<bool> IsConnected()
        {
            try
            {
                string? connected = await _httpClient.GetStringAsync("");
                return connected != null;
            }
            catch (HttpRequestException)
            {
                return false;
            }         
        }

        public async Task<bool> Takeoff()
        {
            CommandCompleted result = await Call("takeoff");
            if (!result.Completed)
                return Throw(result.ParseError());

            return true;
        }

        public async Task<bool> Land()
        {
            CommandCompleted result = await Call("land");
            if (!result.Completed)
                return Throw(result.ParseError());

            return true;
        }

        internal async Task<CommandCompleted> Call(string endpoint)
        {
            try
            {
                CommandCompleted? result = await _httpClient.GetFromJsonAsync<CommandCompleted>(endpoint) ?? throw new NotConnectedException();
                return result;
            }
            catch (HttpRequestException)
            {
                throw new NotConnectedException();
            }
        }

        internal bool Throw(Exception? ex)
        {
            if (ex == null)
                return true;

            if (ThrowErrors)
                throw ex;

            return false;
        }
    }
}