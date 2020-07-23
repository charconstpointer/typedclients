using System.Threading.Tasks;
using FooBar.Clients;
using FooBar.Models;

namespace FooBar.Repositories
{
    public interface IPodcastsRepository
    {
        Task<PodcastsResponse> GetAll();
    }

    public class PodcastsRepository : IPodcastsRepository
    {
        private readonly IPodcastClient _podcastsClient;

        public PodcastsRepository(IPodcastClient podcastsClient)
        {
            _podcastsClient = podcastsClient;
        }

        public async Task<PodcastsResponse> GetAll()
        {
            return await _podcastsClient.GetAll();
        }
    }
}