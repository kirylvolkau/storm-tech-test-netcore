using System;
using Microsoft.Extensions.Caching.Memory;

namespace Todo.Cache
{
    public class GravatarCache
    {
        private readonly IMemoryCache _cache;

        public GravatarCache(IMemoryCache cache)
        {
            _cache = cache;
        }

        public void SetName(string hash, string name)
        {
            _cache.Set(hash, name, TimeSpan.FromDays(1));
        }

        public string GetName(string hash)
        {
            return _cache.Get<string>(hash);
        }
    }
}
