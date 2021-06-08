using System;

/*

Terminology: Delegate
* An objectified function
  - Inherits from System.Delegate
  - Sealed implicity
  - Looks much like C/C++ style function pointer

* A delegate maintains three important pieces of information
  - The address of the method on which it makes calls
  - The parameters (if any) of this method
  - The return type (if any) of this method
 
Type of Delegates
* Singlecast Delegates: Points to a single method at a time.
* Multicast Delegates: Points to more than one function at a time

Important Points About Delegates:

* Provides a good way to encapsulate the methods.
* Delegates are the library class in System namespace.
* These are the type-safe pointer of any method.
* Delegates are mainly used in implementing the call-back methods and events.
* Delegates can be chained together as two or more methods can be called on a single event.
* It doesn’t care about the class of the object that it references.
* Delegates can also be used in “anonymous methods” invocation.
* Anonymous Methods(C# 2.0) and Lambda expressions(C# 3.0) are compiled to delegate types in certain contexts. 
  Sometimes, these features together are known as anonymous functions.
  
 */

namespace DelegateExample
{
    public class Program
    {
        public class MyDelegate
        {
            public delegate void DelegateExample(int a);

            public static void PrintInt(int a)
            {
                Console.WriteLine("Parameter is "+a);
            }

            public static void PrintType<T>(T a)
            {
                Console.WriteLine("Type of parameter is "+a.GetType());
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate example method d1() is ");
            MyDelegate.DelegateExample d1 = MyDelegate.PrintInt;
            d1(1);
            Console.WriteLine("\nDelegate example method d2() is ");
            MyDelegate.DelegateExample d2 = MyDelegate.PrintType;
            d2(1);
            Console.WriteLine("\nDelegate example method d3() is ");
            MyDelegate.DelegateExample d3 = d1 + d2;
            d3(1);
            Console.WriteLine("\nDelegate example method d4() is ");
            MyDelegate.DelegateExample d4 = d3 - d2;
            d4(1);
            Console.WriteLine("\nResult of d4() == d1() is ");
            Console.WriteLine(d4 == d1);
   
        }
    }
}
