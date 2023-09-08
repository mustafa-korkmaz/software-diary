## What?
Builder is a design pattern whose intent is to separate the construction of a complex object from its representation. 
So that the same construction process can create different representations.   
**Frequency of use**: :star::star: (Low)

## Components
- Builder
- ConcreteBuilder
- Director
- Product
 
## Advantages
- Encapsulates code for construction and representation.
- Provides control over steps of construction process.

## Disadvantages
- Separate ConcreteBuilder must be created for each type of product which 
increase complexity for simple object creation scenarios.