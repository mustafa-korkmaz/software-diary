## What?
Singleton is a design pattern implemented inside a class which has only one instance in the program that provides a global point of access to it. In other words, a singleton is a class that allows only a single instance of itself to be created and usually gives simple access to that instance.

**Frequency of use**: :star::star::star::star: (High)
 
## Advantages
- Can implement interfaces.
- Can be lazy-loaded and have static initialization.
- Provides a single point of access to a particular instance, so it is easy to maintain.

## Disadvantages
- Diffucult unit testing. The more you separate object creation from business logic the easier/better you test your code. Singleton classes prevent this by their nature.
- Requires locking for thread safety hence bad when used with multi-threading.

## Real-world study case
Study case shows us how Singleton design pattern can be used while implementing an application level in-memory cache object.
Singleton class `ApplicationCache` has a property named `Instance` which ensures the single point of access for the `ApplicationCache` object.
Regardless how many times `Instance` property has been called across the application, caller always going to get the same instance of `ApplicationCache` class. 

```
//non-public ctor prevents new initilizations
private ApplicationCache()
{
   _cache = new MemoryCache(new MemoryCacheOptions());
}
```

```
var cache1 = ApplicationCache.Instance;
var cache2 = ApplicationCache.Instance;
.
.
var cache_n = ApplicationCache.Instance;
```
	
_ReferenceEquals_ compares the references of two objects and shows whether both have the same address on memory or not.
`object.ReferenceEquals(cache1, cache_n); //True`

#### References
- [c-sharpcorner](https://www.c-sharpcorner.com/UploadFile/8911c4/singleton-design-pattern-in-C-Sharp/) 
- [dofactory](https://dofactory.com/net/singleton-design-pattern) 
- [dzone](https://dzone.com/articles/singleton-anti-pattern)
