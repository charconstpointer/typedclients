using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FooBar.Models;

namespace FooBar.Clients
{
    public class PodcastsClient : IPodcastClient
    {
        private readonly HttpClient _httpClient;

        public PodcastsClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PodcastsResponse> GetAll()
        {
            var podcasts = await _httpClient.GetFromJsonAsync<PodcastsResponse>("https://apipodcasts.polskieradio.pl/api/podcasts");
            // var podcasts = await _httpClient.GetAsync("https://apipodcasts.polskieradio.pl/api/podcasts");
            // var content = await podcasts.Content.ReadAsStringAsync();
            // var json = JsonConvert.DeserializeObject<PodcastsResponse>(content);
            //
            // return json;
            return podcasts;
        }
    }
}