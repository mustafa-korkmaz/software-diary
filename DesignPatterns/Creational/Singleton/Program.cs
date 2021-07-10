using System;
using Microsoft.Extensions.Caching.Memory;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var cache1 = ApplicationCache.Instance;
            var cache2 = ApplicationCache.Instance;

            //compare instance references
            Console.WriteLine(object.ReferenceEquals(cache1, cache2)); //True

            cache1.Set("foo", "bar");

            var result = cache1.Get("foo"); //bar

            Console.WriteLine(result.ToString());

            result = cache2.Get("foo");

            Console.WriteLine(result.ToString());  //bar
        }

        /// <summary>
        /// singleton class
        /// </summary>
        public class ApplicationCache
        {
            private readonly IMemoryCache _cache;

            static ApplicationCache _instance;

            private static readonly object locker = new object();

            private ApplicationCache()
            {
                _cache = new MemoryCache(new MemoryCacheOptions());
            }

            public static ApplicationCache Instance
            {
            get
                {
                    if (_instance == null)
                    {
                        // thread safety
                        lock (locker)
                        {
                            if (_instance == null)
                            {
                                _instance = new ApplicationCache();
                            }
                        }
                    }

                    return _instance;
                }
            }

            public object Get(string key)
            {
                return _cache.TryGetValue(key, out object val) ? val : null;
            }

            public void Set(string key, object item)
            {
                _cache.Set(key, item, DateTimeOffset.MaxValue);
            }
        }
    }
}
