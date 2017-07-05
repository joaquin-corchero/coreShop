using System;
using System.Collections.Generic;
using coreShop.Models;

namespace coreShop.Services
{
    public interface ITweetRepository
    {
        IEnumerable<Tweet> Tweets { get; }
    }

    public class TweetRepository : ITweetRepository
    {
        public IEnumerable<Tweet> Tweets => new List<Tweet>()
        {
            new Tweet{Id = Guid.NewGuid(), Message = "1"},
            new Tweet{Id = Guid.NewGuid(), Message = "2"},
            new Tweet{Id = Guid.NewGuid(), Message = "3"},
            new Tweet{Id = Guid.NewGuid(), Message = "4"}
        };
    }
}
