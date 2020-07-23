using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FooBar.Repositories;
using MediatR;

namespace FooBar.Queries
{
    public class ExampleQuery : IRequest<object>
    {
    }

    public class ExampleQueryHandler : IRequestHandler<ExampleQuery, object>
    {
        private readonly IPodcastsRepository _podcastsRepository;

        public ExampleQueryHandler(IPodcastsRepository podcastsRepository)
        {
            _podcastsRepository = podcastsRepository;
        }

        public async Task<object> Handle(ExampleQuery request, CancellationToken cancellationToken)
        {
            return await _podcastsRepository.GetAll();
        }
    }
}