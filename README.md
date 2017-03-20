# Samples of .NET design patterns

Here you can find the most popular .NET patterns. You can borrow ideas from this repository and implement them in your solutions.
Contributions are always welcome!

* [.NET design patterns](#dotnet-design-patterns)
  * [Behavioral patterns](#behavioral)
    * [Chain of responsibility](#chain-of-responsibility)
  * [Generating patterns](#generating)
    * [Builder](#builder)
    * [Singleton](#singleton)
    * [Prototype](#prototype)
    * [Null Object](#null-object)
    * [Object Pool](#object-pool)
    * [Factory Method](#factory-method)
    * [Abstract Factory](#abstract-factory)
  * [Structural patterns](#structural)
    * [Adapter](#adapter)
    * [Composite](#composite)

## Behavioral
## [Chain of responsibility](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Behavioral/ChainOfResponsibility/SampleLauncher.cs)

* This patterns can be used, when we need to oraganize some levels of responsibility in our system/application. [wiki](https://en.wikipedia.org/wiki/Chain-of-responsibility_pattern)
  * This pattern is recommended in the following cases:
    * You have a group of objects, which can handle messages of a certain type.
    * All messages should be handled at least by one handler in a system.
    * The messages in a system handle by the next scheme "Handle by yourself or send to other", it means, that some messages we handle on the level where we get them and the others we send to the objects of another level.  

## Generating
## [Builder](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/Builder/SampleLauncher.cs)

* The builder pattern is responsible for separating constructing of large object from his representation. It means, that you can receive different representation after the similar construction process. [wiki](https://en.wikipedia.org/wiki/Builder_pattern)
  * This pattern is recommended in the following cases:
    * You should construct a large object with many different properties.
    * You should construct one object from another.
    
## [Singleton](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/Singleton/SampleLauncher.cs)

* This is a generating pattern, which provides you with guarantee, that this object is only one in the one-thread application and has global access point. [wiki](https://en.wikipedia.org/wiki/Singleton_pattern)
  * This pattern is recommended in the following cases:
    * You need an instace of an object, which has a single representation withit a system.
    * You need an access to some resource, which is used by different parts of our application like a unity container.

## [Prototype](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/Prototype/SampleLauncher.cs)
* This is a generating patter, which is used when the type of objects to create is determined by a prototypical instance, which is cloned to produce new objects. [wiki](https://en.wikipedia.org/wiki/Prototype_pattern)
  * This pattern is recommended in the following cases:
    * When you need to avoid subclasses of an object creator in the client application, like the abstract factory pattern does.
    * When you should avoid the inherent cost of creating a new object in the standard way (e.g., using the 'new' keyword) when it is prohibitively expensive for a given application.

## [Null Object](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/NullObject/SampleLauncher.cs)
* This is a generating patter, instead of using a null reference to convey absence of an object (for instance, a non-existent customer), one uses an object which implements the expected interface, but whose method body is empty. The advantage of this approach over a working default implementation is that a Null Object is very predictable and has no side effects: it does nothing. [wiki](https://en.wikipedia.org/wiki/Null_Object_pattern)
  * This pattern is recommended in the following cases:
    * When you have many objects, which implement special interface and you have to perform some action without any errors.
    * This pattern can also be used to act as a stub for testing, if a certain feature such as a database is not available for testing.

## [Object Pool](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/ObjectPool/SampleLauncher.cs)
* The object pool design pattern creates a set of objects that may be reused. When a new object is needed, it is requested from the pool. If a previously prepared object is available it is returned immediately, avoiding the instantiation cost. If no objects are present in the pool, a new item is created and returned. [wiki](https://en.wikipedia.org/wiki/Object_pool_pattern)
  * This pattern is recommended in the following cases:
    * You shoul work with a large number of objects that are particularly expensive to instantiate and each object is only needed for a short period of time.
    * You want to improve performance of some piece of code, where you have many objects, which you can reuse.
* As well you can find a perfect example of object pool pattern from Googler [here](http://stackoverflow.com/questions/2510975/c-sharp-object-pooling-pattern-implementation) (answer with number five).
  
## [Factory Method](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/FactoryMethod/SampleLauncher.cs)
* This is a generating pattern, it defines an interface for creating objects, however leaves the decision of which class should be created to subclasses. In conclusion, factory method allow class to delegate an instantiation to subclasses. [wiki](https://en.wikipedia.org/wiki/Factory_method_pattern)
  * This pattern is recommended in the following cases:
    * The object's creation leads to a significant duplication of code.
    * The object's creation does not provide a sufficient level of abstraction.
    * The object's creation requires information not accessible to the composing object.

##  [Abstract Factory](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/AbstractFactory/SampleLauncher.cs)
* This is a generating pattern and it represents the strategy for creating a family of dependent or related objects. [wiki](https://en.wikipedia.org/wiki/Abstract_factory_pattern)
  * This pattern is recommended in the following cases:
    * You have to create many different objects and they inherited from the similar class or they have lots of similar properties.
    * You want to change behavior of your code by using different classes which implement a similar interface.

## Structural
## [Adapter](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Structural/Adapter/SampleLauncher.cs)

* This is a structural pattern, that allows the interface of an existing class to be used as another interface. It is often used to make existing classes work with others without modifying their source code. [wiki](https://en.wikipedia.org/wiki/Adapter_pattern)
  * This pattern is recommended in the following cases:
    * When you have to create a wrapper, that must respect a particular interface and must support polymorphic behavior.
    * When you have a situation, where classes with different interfaces should work together.
    
## [Composite](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Structural/Composite/SampleLauncher.cs)

* This is a structural pattern, that describes that a group of objects is to be treated in the same way as a single instance of an object. The intent of a composite is to "compose" objects into tree structures to represent part-whole hierarchies. Implementing the composite pattern lets clients treat individual objects and compositions uniformly. [wiki](https://en.wikipedia.org/wiki/Composite_pattern)
  * This pattern is recommended in the following cases:
    * When you have a situation, where you can ignore the difference between compositions of objects and individual objects.
    * When you have a situation, where you are using multiple objects in the same way, and you often have nearly identical code to handle each of them.
