# Samples of .NET design patterns

Here you can find the most popular .NET patterns. You can borrow ideas from this repository and implement them in your solutions.
Contributions are always welcome!

* [.NET design patterns](#dotnet-design-patterns)
 * [Behavioral patterns](#behavioral)
    * [Chain of responsibility](#chain-of-responsibility)
 * [Generating patterns](#generating)
    * [Builder](#builder)
    * [Singleton](#singleton)
    * [Factory Method](#factory-method)
    * [Abstract Factory](#abstract-factory)

## Behavioral
## [Chain of responsibility](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Behavioral/ChainOfResponsibility/SampleLauncher.cs)

* This patterns can be used, when we need to oraganize some levels of responsibility in our system/application.
  * This pattern is recommended in the following cases:
    * You have a group of objects, which can handle messages of a certain type.
    * All messages should be handled at least by one handler in a system.
    * The messages in a system handle by the next scheme "Handle by yourself or send to other", it means, that some messages we handle on the level where we get them and the others we send to the objects of another level.  

## Generating
## [Builder](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/Builder/SampleLauncher.cs)

* The builder pattern is responsible for separating constructing of large object from his representation. It means, that you can receive different representation after the similar construction process.
  * This pattern is recommended in the following cases:
    * You should construct a large object with many different properties.
    * You should construct one object from another.
    
## [Singleton](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/Singleton/SampleLauncher.cs)

* This is a generating pattern, which provides you with guarantee, that this object is only one in the one-thread application and has global access point. 
  * This pattern is recommended in the following cases:
    * You need an instace of an object, which has a single representation withit a system.
    * You need an access to some resource, which is used by different parts of our application like a unity container.

## [Factory Method](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/FactoryMethod/SampleLauncher.cs)
* This is a generating pattern, it defines an interface for creating objects, however leaves the decision of which class should be created to subclasses. In conclusion, factory method allow class to delegate an instantiation to subclasses.
  * This pattern is recommended in the following cases:
    * The object's creation leads to a significant duplication of code.
    * The object's creation does not provide a sufficient level of abstraction.
    * The object's creation requires information not accessible to the composing object.

##  [Abstract Factory](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/AbstractFactory/SampleLauncher.cs)

* This is a generating pattern and it represents the strategy for creating a family of dependent or related objects.
  * This pattern is recommended in the following cases:
    * You have to create many different objects and they inherited from the similar class or they have lots of similar properties.
    * You want to change behavior of your code by using different classes which implement a similar interface.
