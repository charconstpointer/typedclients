using System.Collections.Generic;

namespace FooBar.Models
{
    public class PodcastsResponse
    {
        public IEnumerable<Podcast> Items { get; set; }
    }

    public class Podcast
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}