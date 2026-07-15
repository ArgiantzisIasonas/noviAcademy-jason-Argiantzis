namespace GateWay
{
    public class PlayerHttpClient : IPlayersHttpClient
    {
        private readonly HttpClient _httpClient;

        public PlayerHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
    }
}
