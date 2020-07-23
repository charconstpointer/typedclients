using System.Net.Http;
using System.Threading.Tasks;

namespace FooBar.Clients
{
    public class PodcastsClient : IPodcastClient
    {
        private readonly HttpClient _httpClient;

        public PodcastsClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetAll()
        {
            var podcasts = await _httpClient.GetStringAsync("https://apipodcasts.polskieradio.pl/api/podcasts");
            return podcasts;
        }
    }
}