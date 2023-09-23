using DJIControlClient.Exceptions;
using DJIControlClient.Models;
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

        internal async Task<CommandCompleted<T>> Call<T>(string endpoint)
        {
            try
            {
                CommandCompleted<T>? result = await _httpClient.GetFromJsonAsync<CommandCompleted<T>>(endpoint) ?? throw new NotConnectedException();
                return result;
            }
            catch (HttpRequestException)
            {
                throw new NotConnectedException();
            }
        }
    }

    // "Properties"
    public partial class Drone
    {
        public async Task<bool> IsLandingProtectionEnabled()
        {
            CommandCompleted<bool?> result = await Call<bool?>("isLandingProtectionEnabled");
            if (!result.Completed)
                throw result.ParseError();

            return result.State != null && result.State.Value;
        }

        public async Task SetLandingProtection(bool enabled)
        {
            string endpoint = enabled ? "enableLandingProtection" : "disableLandingProtection";

            CommandCompleted result = await Call(endpoint);
            if (!result.Completed)
                throw result.ParseError();
        }
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