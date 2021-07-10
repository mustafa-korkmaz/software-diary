﻿# Singleton Design Pattern (Thread safe and lazy-loaded)
In this pattern, a class has only one instance in the program that provides a global point of access to it. In other words, a singleton is a class that allows only a single instance of itself to be created and usually gives simple access to that instance.

**Frequency of use**: :star::star::star::star: (High)
 
## Advantages
- Can implement interfaces.
- Can be lazy-loaded and has static Initialization.
- Provides a single point of access to a particular instance, so it is easy to maintain.

## Disadvantages
- Diffucult unit testing
- Requires locking for thread safety


#### References
- [c-sharpcorner](https://www.c-sharpcorner.com/UploadFile/8911c4/singleton-design-pattern-in-C-Sharp/) 
- [dofactory](https://dofactory.com/net/singleton-design-pattern) 