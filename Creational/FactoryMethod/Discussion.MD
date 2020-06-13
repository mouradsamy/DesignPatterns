# Factory Method Design Pattern

- [Description](#description)
- [Intent](#intent)
- [Problem](#problem)
- [Example](#example)
- [Check List](#check_list)
- [Rules of thump](#rules_of_thumb)
- [Advantages](#advantages)
- [Disadvantages](#disadvantages)


### <a name="description"></a>Description
- A factory method handles object creation and encapsulates it in
a subclass. This decouples the client code in the superclass from
the object creation code in the subclass.
- A factory method isolates the client (the code in the superclass, like orderPizza()) from knowing what kind of concrete Product is actually created.
- A factory method may be parameterized (or not) to select among several variations of a product.
- A factory method returns a Product that is typically used within methods defined in the superclass.
- A factory method is abstract so the subclasses are counted on to handle object creation.

### <a name="intent"></a>Intent
Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.
Defining a "virtual" constructor.
The new operator considered harmful.

### <a name="problem"></a>Problem
A framework needs to standardize the architectural model for a range of applications, but allow for individual applications to define their own domain objects and provide for their instantiation.

### <a name="example"></a>Example
This real-world code demonstrates the Factory method offering flexibility in creating different documents. The derived Document classes Report and Resume instantiate extended versions of the Document class. Here, the Factory Method is called in the constructor of the Document base class.

### <a name="check_list"></a>Check list
- If you have an inheritance hierarchy that exercises polymorphism, consider adding a polymorphic creation capability by defining a static factory method in the base class.
- Design the arguments to the factory method. What qualities or characteristics are necessary and sufficient to identify the correct derived class to instantiate?
- Consider designing an internal "object pool" that will allow objects to be reused instead of created from scratch.
- Consider making all constructors private or protected.

### <a name="rules_of_thumb"></a>Rules of thumb
- Abstract Factory classes are often implemented with Factory Methods, but they can be implemented using Prototype.
- Factory Methods are usually called within Template Methods.
- Factory Method: creation through inheritance. Prototype: creation through delegation.
Often, designs start out using Factory Method (less complicated, more customizable, subclasses proliferate) and evolve toward Abstract Factory, Prototype, or Builder (more flexible, more complex) as the designer discovers where more flexibility is needed.
- Prototype doesn't require subclassing, but it does require an Initialize operation. Factory Method requires subclassing, but doesn't require Initialize.
- The advantage of a Factory Method is that it can return the same instance multiple times, or can return a subclass rather than an object of that exact type.
- Some Factory Method advocates recommend that as a matter of language design (or failing that, as a matter of style) absolutely all constructors should be private or protected. It's no one else's business whether a class manufactures a new object or recycles an old one.
- The new operator considered harmful. There is a difference between requesting an object and creating one. The new operator always creates an object, and fails to encapsulate object creation. A Factory Method enforces that encapsulation, and allows an object to be requested without inextricable coupling to the act of creation.