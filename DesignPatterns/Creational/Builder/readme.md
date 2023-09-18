## What?
Builder is a design pattern whose intent is to separate the construction of a complex object from its representation. 
So that the same construction process can create different representations.   
**Frequency of use**: :star::star: (Low)

## Components
- Builder (`ComputerBuilder`)
- ConcreteBuilder (`GamingComputerBuilder, DevelopmentComputerBuilder`)
- Director (`PCStore`)
- Product (`Computer`)
 
## Advantages
- Encapsulates code for construction and representation.
- Provides control over steps of construction process.

## Disadvantages
- Separate ConcreteBuilder must be created for each type of product which 
increase complexity for simple object creation scenarios.

## Real-world study case
In this study case, we will need to construct two `Computer` products to be used for _gaming_ and _development_ purposes.  
A gaming computer would need a strong GPU as well as disk size while a development one would require a powerful CPU and RAM resources.  
The concrete builders `GamingComputerBuilder` and `DevelopmentComputerBuilder` will help the director class (`PCStore`) construct the `Computer` product by implementing the abstract builder class `ComputerBuilder`

#### References
- [dofactory](https://dofactory.com/net/builder-design-pattern) 
- [Wikipedia](https://en.wikipedia.org/wiki/Builder_pattern)
