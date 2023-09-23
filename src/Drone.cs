namespace DJIControlClient
{
    public class Drone
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
    }
}