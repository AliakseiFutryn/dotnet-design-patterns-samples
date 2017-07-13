# Samples of .NET design patterns

Here you can find the most popular .NET patterns. You can borrow ideas from this repository and implement them in your solutions.
Contributions are always welcome!

* [.NET design patterns](#dotnet-design-patterns)
  * [Behavioral patterns](#behavioral)
    * [Iterator](#iterator)
    * [Dispose](#dispose)
    * [Observer](#observer)
    * [Mediator](#mediator)
    * [Memento](#memento)
    * [Command](#command)
    * [Interpreter](#interpreter)
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
## [Iterator](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/tree/master/Behavioral/Iterator)

* This pattern can be used, when you need to get access to all elements of a composite object without disclosure of its representation. [wiki](https://en.wikipedia.org/wiki/Iterator_pattern)
  * This pattern is recommended in the following cases:
    * You need to implement your own collection with specific logic.
    * You need to implement your own properties and methods which usual collections does not have.
    * You need to iterate elements in a collection by using your own logic.

## [Dispose](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/tree/master/Behavioral/Dispose)

* This pattern can be used, when you need to manage memory of managed and unmanaged resources. [wiki](https://en.wikipedia.org/wiki/Dispose_pattern)
  * This pattern is recommended in the following cases:
    * You have to deal with managed and unmanaged resources in your solution.
    * You have to deal with managed resources, make sure that in this case you do not need to use the full version of disposable pattern.
    * You want to control the memory in your application, as it is very important.

# [Observer](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/tree/master/Behavioral/Observer)

* This pattern can be used, when you want to have a heap of dependent objects which can notify each other about its changes. [wiki](https://en.wikipedia.org/wiki/Observer_pattern)
  * This pattern is recommended in the following cases:
    * You have a heap of dependent objects and you want to notify all objects, when one of them was changed.
    * You want to notify some objects, when observer state changed.
    * You have some pieces of your code, which should be notified in case, when observer was changed.

## [Mediator](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/tree/master/Behavioral/Mediator)

* This pattern can be used, when you need to interact between two different objects or two different providers. [wiki](https://en.wikipedia.org/wiki/Mediator_pattern)
  * This pattern is recommended in the following cases:
    * You need to interact between one or many different classes.
    * You need to interact between classes which cannot have direct link to each other.
    * You want to change and analyse classes independently.
    
## [Memento](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/tree/master/Behavioral/Memento)

* This pattern can be used, when you need to restore an object to its previous state. [wiki](https://en.wikipedia.org/wiki/Memento_pattern)
  * This pattern is recommended in the following cases:
    * You want to have an opportunity to restore object previous state.
    * You want to restore the previous state of many objects.
    * You want to return to the previous code behavior after sometime.

## [Command](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/tree/master/Behavioral/Command)

* This pattern can be used, when we need to create a system where a sender and receiver will be independend of each other. [wiki](https://en.wikipedia.org/wiki/Command_pattern)
  * This pattern is recommended in the following cases:
    * You need to make sender and receiver to be independed of each other.
    * You have to get a command as a result like any other objects.
    * You want to process a command like an object. It will allow you to save command or pass a command as a parameter to methods.

## [Interpreter](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/tree/master/Behavioral/Interpreter)

* This pattern can be used, when you need to interpret some symbol (terminal or non-terminal) into C# computer language. [wiki](https://en.wikipedia.org/wiki/Interpreter_pattern)
  * This pattern is recommended in the following cases:
    * You need to evaluate sentences in a language.
    * You need to interpret some symbols into C# langunage.
    * You want to create your own langunage interpreter.

## [Chain of responsibility](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Behavioral/ChainOfResponsibility)

* This pattern can be used, when we need to oraganize some levels of responsibility in our system/application. [wiki](https://en.wikipedia.org/wiki/Chain-of-responsibility_pattern)
  * This pattern is recommended in the following cases:
    * You have a group of objects, which can handle messages of a certain type.
    * All messages should be handled at least by one handler in a system.
    * The messages in a system handle by the next scheme "Handle by yourself or send to other", it means, that some messages we handle on the level where we get them and the others we send to the objects of another level.  

## Generating
## [Builder](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/Builder)

* The builder pattern is responsible for separating constructing of large object from his representation. It means, that you can receive different representation after the similar construction process. [wiki](https://en.wikipedia.org/wiki/Builder_pattern)
  * This pattern is recommended in the following cases:
    * You should construct a large object with many different properties.
    * You should construct one object from another.
    
## [Singleton](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/Singleton)

* This is a generating pattern, which provides you with guarantee, that this object is only one in the one-thread application and has global access point. [wiki](https://en.wikipedia.org/wiki/Singleton_pattern)
  * This pattern is recommended in the following cases:
    * You need an instace of an object, which has a single representation withit a system.
    * You need an access to some resource, which is used by different parts of our application like a unity container.

## [Prototype](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/Prototype)
* This is a generating patter, which is used when the type of objects to create is determined by a prototypical instance, which is cloned to produce new objects. [wiki](https://en.wikipedia.org/wiki/Prototype_pattern)
  * This pattern is recommended in the following cases:
    * When you need to avoid subclasses of an object creator in the client application, like the abstract factory pattern does.
    * When you should avoid the inherent cost of creating a new object in the standard way (e.g., using the 'new' keyword) when it is prohibitively expensive for a given application.

## [Null Object](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/NullObject)
* This is a generating patter, instead of using a null reference to convey absence of an object (for instance, a non-existent customer), one uses an object which implements the expected interface, but whose method body is empty. The advantage of this approach over a working default implementation is that a Null Object is very predictable and has no side effects: it does nothing. [wiki](https://en.wikipedia.org/wiki/Null_Object_pattern)
  * This pattern is recommended in the following cases:
    * When you have many objects, which implement special interface and you have to perform some action without any errors.
    * This pattern can also be used to act as a stub for testing, if a certain feature such as a database is not available for testing.

## [Object Pool](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/ObjectPool)
* The object pool design pattern creates a set of objects that may be reused. When a new object is needed, it is requested from the pool. If a previously prepared object is available it is returned immediately, avoiding the instantiation cost. If no objects are present in the pool, a new item is created and returned. [wiki](https://en.wikipedia.org/wiki/Object_pool_pattern)
  * This pattern is recommended in the following cases:
    * You shoul work with a large number of objects that are particularly expensive to instantiate and each object is only needed for a short period of time.
    * You want to improve performance of some piece of code, where you have many objects, which you can reuse.
* As well you can find a perfect example of object pool pattern from Googler [here](http://stackoverflow.com/questions/2510975/c-sharp-object-pooling-pattern-implementation) (answer with number five).
  
## [Factory Method](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/FactoryMethod)
* This is a generating pattern, it defines an interface for creating objects, however leaves the decision of which class should be created to subclasses. In conclusion, factory method allow class to delegate an instantiation to subclasses. [wiki](https://en.wikipedia.org/wiki/Factory_method_pattern)
  * This pattern is recommended in the following cases:
    * The object's creation leads to a significant duplication of code.
    * The object's creation does not provide a sufficient level of abstraction.
    * The object's creation requires information not accessible to the composing object.

##  [Abstract Factory](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/AbstractFactory)
* This is a generating pattern and it represents the strategy for creating a family of dependent or related objects. [wiki](https://en.wikipedia.org/wiki/Abstract_factory_pattern)
  * This pattern is recommended in the following cases:
    * You have to create many different objects and they inherited from the similar class or they have lots of similar properties.
    * You want to change behavior of your code by using different classes which implement a similar interface.

## Structural
## [Adapter](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Structural/Adapter)

* This is a structural pattern, that allows the interface of an existing class to be used as another interface. It is often used to make existing classes work with others without modifying their source code. [wiki](https://en.wikipedia.org/wiki/Adapter_pattern)
  * This pattern is recommended in the following cases:
    * When you have to create a wrapper, that must respect a particular interface and must support polymorphic behavior.
    * When you have a situation, where classes with different interfaces should work together.
    
## [Composite](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Structural/Composite)

* This is a structural pattern, that describes that a group of objects is to be treated in the same way as a single instance of an object. The intent of a composite is to "compose" objects into tree structures to represent part-whole hierarchies. Implementing the composite pattern lets clients treat individual objects and compositions uniformly. [wiki](https://en.wikipedia.org/wiki/Composite_pattern)
  * This pattern is recommended in the following cases:
    * When you have a situation, where you can ignore the difference between compositions of objects and individual objects.
    * When you have a situation, where you are using multiple objects in the same way, and you often have nearly identical code to handle each of them.
