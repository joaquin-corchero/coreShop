using System.Collections.Generic;
using coreShop.Models;

namespace coreShop.Services
{
    public interface IStoreRepository
    {
        IEnumerable<Tweet> Tweets { get; }
    }

    public class StoreRepository : IStoreRepository
    {
        public IEnumerable<Tweet> Tweets { get; }
    }
}
