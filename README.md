# Samples of .NET design patterns

Here you can find the most popular .NET patterns. You can borrow ideas from this repository and implement them in your solutions.
Contributions are always welcome!

* [.NET design patterns](#dotnet-design-patterns)
 * [Behavioral patterns](#behavioral)
   * [Chain of responsibility](#chain-of-responsibility)
 * [Generating patterns](#generating)
   * [Singleton](#singleton)

## Chain of responsibility

* This patterns can be used, when we need to oraganize some levels of responsibility in our system/application.
  * This pattern is recommended in the following cases:
    * In a developing system we have a group of objects, which can handle messages of a certain type.
    * All messages should be handled at least by one handler in a system.
    * The messages in a system handle by the next scheme "Handle by yourself or send to other", it means, that some messages we handle on the level where we get them and the others we send to the objects of another level.  
  
## Singleton

* This is a generating pattern, which provides you with guarantee, that this object is only one in the one-thread application and has global access point. 
  * This pattern is recommended in the following cases:
    * We need an instace of an object, which has a single representation withit a system.
    * We need an access to some resource, which is used by different parts of our application like a unity container.  
