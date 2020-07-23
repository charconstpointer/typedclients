using System.Threading.Tasks;
using FooBar.Clients;

namespace FooBar.Repositories
{
    public interface IPodcastsRepository
    {
        Task<string> GetAll();
    }

    public class PodcastsRepository : IPodcastsRepository
    {
        private readonly IPodcastClient _podcastsClient;

        public PodcastsRepository(IPodcastClient podcastsClient)
        {
            _podcastsClient = podcastsClient;
        }

        public async Task<string> GetAll()
        {
            return await _podcastsClient.GetAll();
        }
    }
}