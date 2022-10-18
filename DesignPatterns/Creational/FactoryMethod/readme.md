## What?
Factory method is one of the most widely used creational design pattern uses _factory methods_ while creating different objects. It defines the interface for object creation and lets subclasses decide which class to instantiate.

**Frequency of use**: :star::star::star::star::star: (High)
 
## Advantages
- Hides the object instantiation and allows loose coupling 
- Can be used as static method depending on the need
- Easy to implement, easy to test
 

## Disadvantages
 - Might violate [Open–closed principle](https://en.wikipedia.org/wiki/Open%E2%80%93closed_principle) if it is not implemented properly
 - The more products are needed, the more complex it gets especially when _Creator & Concrete Creator_ are used per product

## Real-world study case
In this study case, we are going to need to create a `Payment` object for a payment transaction depending on the option end user chooses.  
If `Stripe` option is selected, the _Factory method_ `GetPayment(PaymentOption paymentOption)` will instantiate a `StripePayment` object as a _Concrete product_  
If `PayPal` is selected the concrete product will be `PayPalPayment`  
`DoPayment(PaymentInfo paymentInfo)` method will use `CreditCardNumber` property in order to complete the transaction for Stripe option while PayPal will be using `AccountHolderIban` for that purpose.
 

#### References
- [dofactory](https://dofactory.com/net/factory-method-design-pattern) 
- [dzone](https://dzone.com/articles/factory-method-design-pattern)
- [Wikipedia](https://en.wikipedia.org/wiki/Factory_method_pattern)
