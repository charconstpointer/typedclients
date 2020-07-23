using System.Threading.Tasks;
using FooBar.Models;

namespace FooBar.Clients
{
    public interface IPodcastClient
    {
        Task<PodcastsResponse> GetAll();
    }
}