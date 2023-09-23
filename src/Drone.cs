using DJIControlClient.Exceptions;
using System.Net.Http.Json;

namespace DJIControlClient
{
    // Root
    public partial class Drone
    {
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
    }

    // Properties
    public partial class Drone
    {

    }

    // Methods
    public partial class Drone
    {
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

        public async Task Takeoff()
        {
            CommandCompleted result = await Call("takeoff");
            if (!result.Completed)
                throw result.ParseError();
        }

        public async Task Land()
        {
            CommandCompleted result = await Call("land");
            if (!result.Completed)
                throw result.ParseError();
        }

        public async Task ConfirmLanding()
        {
            CommandCompleted result = await Call("confirmLanding");
            if (!result.Completed)
                throw result.ParseError();
        }
    }
}