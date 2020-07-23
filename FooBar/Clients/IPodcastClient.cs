using System.Threading.Tasks;

namespace FooBar.Clients
{
    public interface IPodcastClient
    {
        Task<string> GetAll();
    }
}