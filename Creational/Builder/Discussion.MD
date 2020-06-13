# Builder Design Pattern

### Intent
Separate the construction of a complex object from its representation so that the same construction process can create different representations.
Parse a complex representation, create one of several targets.

### Problem
An application needs to create the elements of a complex aggregate. 
The specification for the aggregate exists on secondary storage and one of many representations needs to be built in primary storage.

### Example
The Builder pattern separates the construction of a complex object from its representation so that the same construction process can create different representations. 
This pattern is used by fast food restaurants to construct children's meals. 
Children's meals typically consist of a main item, a side item, a drink, and a toy (e.g., a hamburger, fries, Coke, and toy dinosaur). 
Note that there can be variation in the content of the children's meal, but the construction process is the same. Whether a customer orders a hamburger, cheeseburger, or chicken, the process is the same. 
The employee at the counter directs the crew to assemble a main item, side item, and toy. 
These items are then placed in a bag. The drink is placed in a cup and remains outside of the bag. 
This same process is used at competing restaurants.

### Check list
Decide if a common input and many possible representations (or outputs) is the problem at hand.
Encapsulate the parsing of the common input in a Reader class.
Design a standard protocol for creating all possible output representations. Capture the steps of this protocol in a Builder interface.
Define a Builder derived class for each target representation.
The client creates a Reader object and a Builder object, and registers the latter with the former.
The client asks the Reader to "construct".
The client asks the Builder to return the result.

### Rules of thumb
- Sometimes creational patterns are complementary: Builder can use one of the other patterns to implement which components get built. Abstract Factory, Builder, and Prototype can use Singleton in their implementations.
- Builder focuses on constructing a complex object step by step. Abstract Factory emphasizes a family of product objects (either simple or complex). Builder returns the product as a final step, but as far as the Abstract Factory is concerned, the product gets returned immediately.
- Builder often builds a Composite.
- Often, designs start out using Factory Method (less complicated, more customizable, subclasses proliferate) and evolve toward Abstract Factory, Prototype, or Builder (more flexible, more complex) as the designer discovers where more flexibility is needed.