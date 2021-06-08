## Delegate Example

### Terminology: Delegate
* An objectified function
  - Inherits from System.Delegate
  - Sealed implicity
  - Looks much like C/C++ style function pointer

* A delegate maintains three important pieces of information
  - The address of the method on which it makes calls
  - The parameters (if any) of this method
  - The return type (if any) of this method
 
### Type of Delegates
* Singlecast Delegates: Points to a single method at a time.
* Multicast Delegates: Points to more than one function at a time

### Important Points About Delegates:
* Provides a good way to encapsulate the methods.
* Delegates are the library class in System namespace.
* These are the type-safe pointer of any method.
* Delegates are mainly used in implementing the call-back methods and events.
* Delegates can be chained together as two or more methods can be called on a single event.
* It doesn’t care about the class of the object that it references.
* Delegates can also be used in “anonymous methods” invocation.
* Anonymous Methods(C# 2.0) and Lambda expressions(C# 3.0) are compiled to delegate types in certain contexts. 
  Sometimes, these features together are known as anonymous functions.
### Important Points About Delegates:
* Action<> and Func<> Delegates
  - Action<> Delegates: Accepts one or more arguments without a return value
  - Func<> Delegate: Accepts oe or more argumets and returns a value. Final paramether of Func<> is always the return value of the method
    ex. Func<int, int, string> | return value is string!!!
