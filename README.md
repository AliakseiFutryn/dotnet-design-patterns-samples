# Samples of .NET design patterns

Here you can find the most popular .NET patterns. You can borrow ideas from this repository and implement them in your solutions.
Contributions are always welcome!

* [.NET design patterns](#dotnet-design-patterns)
 * [Behavioral patterns](#behavioral)
   * [Chain of responsibility](#chain-of-responsibility)

## Chain of responsibility

* This patterns can be used, when we need to oraganize some levels of responsibility in our system/application.
  * This pattern is recommended in the following cases:
    * In a developing system we have a group of objects, which can handle messages of a certain type.
    * All messages should be handled at least by one handler in a system.
    * The messages in a system handle by the next scheme "Handle by yourself or send to other", it means, that some messages we handle on the level where we get them and the others we send to the objects of another level.  
  
