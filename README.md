		
	Design Patterns in C# course completed @Udemy

Various Design Patterns explained via code examples written in C#

=========================================================================================
	CREATIONAL PATTERNS
- Deal with creation (construction of an objects)
	- Explicit (constructor) vs implicit (DI, reflection, etc.)z
	- Wholesale (single statement) vs piecewise (step-by-step needs to be taken in order for the object to be initialized)

	
	STRUCTURAL PATTERNS
- Concerned with the structure (ex. class members)
- Many patterns are 'wrappers' that mimic the underlying class' interface
- Stress the importance of good API design

	BEHAVIORAL PATTERNS
- They are all different; no central theme..
=========================================================================================

1. Builder (design pattern) - when construction of object is complicated - provide an API for doing it in a step-by-step way

	- Builders are separate component for building an object
	- Can either give builder a constructor or return it (the builder itself) via a static function
	- To make a builder fluent - return this (chain calls together)
	- Different facets of an object can be built with different builders working in tandem via a base class.
	
 ! Facade (or facets) - this class doesn't build up the object - only keeps a reference to it.
	- allows access to subbuilders
=========================================================================================
	
2. Factory (Factory Method and Abstract Factory)
	- when object creation becomes convoluted
	- constructor is not descriptive
		- cannot overload with same sets of args with different names
		- can turn into 'optional parameter hell'
	- object creation (non-piecewise, unlike Builder) can be outsourced to:
		. Separate function (factory method) that can exists in separate class (factory) or reside inside the object as an inner class
		. Can create hierarchy of factories with Abstract Factory
		
! Factory is component responsible for wholesale (not piecewise) object creation.

! The difference between normal and abstract factory is that abstract factories make abstract objects 
	instead of concrete ones (creating abstract classes or interfaces)
=========================================================================================
	
	
3. Prototype - A partially or fully initialized object that we copy (clone) and make use of
	- prototype is an existing object which can be partially or fully constructed
		- we make a copy (or clone) of it and customize it (requires 'deep copy' support)
		
			! Deep copy is copying all properties recursively
			! Shallow copy copies the reference of reference types
			! IClonable is making a shallow copy
			! In real world deep copy is done via serialization (ex. XML)
				
		- we make the copying convenient (ex. Factory)
=========================================================================================
		
4. Singleton - A component that is instantiated just once
	- For some components it only make sense to have one instance in the system
		. Database
		. Object factory (factories aren't supposed to have any state (data))
	- When constructor call is expensive
		. We only do it once
		. We provide the same instance everywhere needed
	- Should prevent anyone from creating additional instances
	- Need to take care of lazy instantiation and thread safety
		- Make static Lazy<T> and return its value
	- Resolve the 'test issue' by depending on abstraction (DIP)
	- Consider defining singleton lifetime in DI container
=========================================================================================
	
5. Adapter - A construct which adapts an existing interface X to conform to the required interface Y
	- Getting the interface we need from the interface we have
	- Create component that has reference to the adaptee (the component that needs adapting)
	- Side effect is that we create a lot of temporary information - needs caching
=========================================================================================
	
6. Bridge - A mechanism that decouples an interface (hierarchy) from an implementation (hierarchy)
	- prevents a 'Cartesian product' complexity explosion
	- avoids entity explosion
=========================================================================================
	
7. Composite - A mechanism of treating individual (scalar) and composite of objects in a uniform manner
	- A single object can masquerade as a collection with 'yield return this'
=========================================================================================
	
8. Decorator - Helps the addition of behaviors to individual objects without inheriting from them
	- We want to add new functionality to an object BUT don't want to rewrtite or alter existing code (OCP)
	- Want to keep new functionality separate (SRP)
	- Two options:
		- inherit from the required object if possible (some objects are sealed) - NOT Decorator pattern
		- build a Decorator, which simply references the decorated object(s) - Decorator pattern
			- Implement interface
			- Extension methods
			- C# 8 default interface members (these member can be called ONLY by interface variables (not class ones))
		- exists a static variation (C# is not suitable for it) - X<Y<Foo>>();y
=========================================================================================
		
9. Facade - Provides a simple, easy to understand user interface over a large and sophisticated body of code
	- Balancing complexity and presentation/usability
	- Facade provides simplified API over a set of classes
	- (optionally) expose internals thru the facade
	- may allow users to 'escalate' to use more complex APIs if they need to
=========================================================================================
	
10. Flyweight - A space optimization technique that lets us use less memory by storing extenally the data associated with similar objects
	- Avoid redundancy when storing data (ex. John Smith name in DB x100 times stored)
		- this is solved by storing a list of names and pointers to them
	- Define the idea of 'ranges' on homogenous collections and store data related to those ranges
=========================================================================================
	
11. Proxy - A class that functions as an interface to a particular resource. That resource may be remote, expensive to construct, or may require logging or other functionality
	- Same interface as the underlying object
		- Then add relevant functionality to the redefined members
	- Many types of proxies: communication, logging, caching, etc.
	
! Difference between Proxy and Decorator:
	- in Proxy we don't add new members, we add new functionality in existing members
	- Proxy provides identical interface, Decorator provides an enhanced one
	- Decorator typically has reference to what it is decorating; proxy doesn't have to
	- Proxy may not even be working with materialized objects
	
- Protection Proxy - something that checks if one has the rights to call a method for example
- Value Proxy - Proxy constructed over a primitive types (ex. int, float)
=========================================================================================

12. Chain of Responsibility - a chain of components who ALL get a chance to process a command or query, optionally having default processing implementation
and an ability to terminate the processing chain
	- can be implemented as chain of references OR a centralized construct
	- object removal from chain (ex. from Dispose)
	
	!Command Query Separation:
		- Command - asking for an action or change (ex. please set attack value to 2)
		- Query - asking for information (ex. please give me your attack value)
		- CQS - having separate means of sending command and queries
=========================================================================================
		
13. Command - An object that represents an instruction to perform some action. Contains all the information necessary for the action to be taken
	- Encapsulate all the details of an operation in a separate object
	- Define an instruction for applying the command (in the command or elsewhere)
	- Optionally define instructions for undoing the command
=========================================================================================
	
14. Interpreter - A component that processes structured text data. Does so by turning it into separate lexical tokens (lexing)
 and then interpreting sequences of such tokens (parsing)
	- Textual input need to be processed (ex. turned into OOP structure)
		- Compilers, interpreters and IDEs are interpreters
=========================================================================================
		
15. Iterator - An object (in .NET can be a method with yield return) that facilitates traversal of a data structure
	- An iterator is a class that helps with traversal (iteration) of data
		- keeps a reference to the current element
		- knows how to move to a different element
		- All that needs to iterate thru object (IEnumerator)
	- Specifies how we can traverse an object
	- Iterator object, unlike a method, cannot be recursive
	- Generally - an IEnumerable<T> returning method is enough
=========================================================================================
	
16. Mediator - A component that facilitates communication between other components without them being aware of each other or having reference to each other
	- Components may go in and out of the system ay any time (ex. chat room or online game)
		- It makes no sense to have direct reference to one another
			- have then all refer to some central component (mediator (typically singleton)) that facilitates communication
	- Mediator engages in bidirectional communication with its connected components
	- Mediator has functions the components can call
	- The components have functions the mediator can call
	- Event processing (ex. Rx) libraries make communication easier to implement
=========================================================================================
	
17. Memento - A token/handle representing the system state. Lets us roll back to the state when the token was generated. (useful for interop*)
May or may not expose state information.
	- Mementos are used to roll back states
	- A token/handle class (typically with no functions on its own)
	- Not required to expose the state to which it reverts the system
	- Can be used to implement undo/redo
=========================================================================================
	
18. Null object - A no-op object that conforms to the required interface, satisfying a dependency requirement of some other object
	- implement the required interface
	- rewrite the methods with empty bodies
		- if non-void - return default(T)
	- supply a null object in place of actual object
=========================================================================================
	
19. Observer - An 'observer' is an object that wishes to be informed about events happening in the system. The entity generating the events is an 'observable'.
	- An observable must provide an event to subscribe to
	- Special care must be taken to prevent issues in multithreaded scenarios
	- .NET has observable collections
	- IObserver<T> and IObservable<T> are used in stream proccessing (Rx)
=========================================================================================
	
20. State - A pattern in which the object's behavior is determined by its state. An object transitions from one state to another (something needs to trigger a transition).
A formalized construct which manages state and transitions is called a 'state machine'

	- Can define:
		- State entry/exit behavior
		- Action when particular event (trigger) causes a transition
		- Guard conditions, enabling/disabling a transition
		- Default action when no transitions are found for an event (trigger)
=========================================================================================
		
21. Strategy - Enables the exact behavior of a system to be selected either at run-time (dynamic) or compile-time (static)
	- Define an algorithm at a high-level
	- Define the interface you expect each strategy to follow
	- Provide for either dynamic or static composition of strategy in the overall algorithm
								Motivation
		-	Many algorithms can be decomposed into higher and loswer-level parts
			- Making a tea can be decomposed to:
				. The process of making hot beverage (high-level part) - boil water, pour into a cup, etc.
				. tea-specific part (lower-level) put teabag into the cup
		-	The high-level part can be reused to make coffee or hot chocolate
	! High-level part uses composition (interface)
	! Template Method uses iheritance
=========================================================================================
		
22. Template Method - Allows us to define the 'skeleton' of the algorithm, with concrete implementations in subclasses
	- Define an algorithm at high-level (usually abstract class)
	- Define members as 'abstract' (so they can earn concreteness in derived classes)
	- Inherit the 'algorithm class' providing necessary overrides
=========================================================================================
	
23. Visitor - A component (visitor) is allowed to traverse the entire inheritance hierarchy. Implemented by propagating a single Visit() method throughout the entire hierarchy
	- Propagate an Accept(Visitor v) method throughout the entire hierarchy
	- Create Visit(<with every type in the hierarchy>) methods
	- Each Accept(Visitor v) just calls v.Visit(this)
	
	! Dispatch - which function to call?
		- Single Dispatch - depends on name of request (method) and type of receiver
		- Double Dispatch - depends on name of request (method) and type of two receivers (type of visitor, type of element being visited)
=========================================================================================