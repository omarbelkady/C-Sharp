


```cs
using System;
using System.Collections.Generic;
using System.Linq;
namespace MyAwesomeProg{
    class OOP {
        static void Main(string [] args) {
            //A field is a way for us to store data in a class
            //A field is similar to a variable except it is at the class level
            //Instead of a method
            //A field is a class level variable
            //Fields are usually behind the scenes elements of a class
            //Properties are what we can see in front of us when using a class
            //Person me = new Person();
            //type Identifier
            
        }
        static void Wr_L(object o)=>Console.WriteLine(o);
     
        
        static void Wr_i(object m)=>Console.Write(m);
      
    }
    
    //This is an Auto implemented Property
    class Nelan{
        //Name is a field but do not ever do this practice always make your fields private
        public string Name{
            get;
            set;
        }
        
        //SSN is a property 
        public int SSN{
            get;
            private set;
        }
    }
}
```
## 4 Main Topics
* Encapsulation: the process of putting a layer around something.
To put a shield on the inner details of it and give us the power to expose only what we want to expose. 
This is mainly used in Fields. Fields are variables at the class level. Encapsulation allow us to use 
Now properties act a gate to the fields. We have to go through a property for us to get or set the field. Encapsulation prevents any outside source
to see the implementation of our function in contrast to Abstraction(which exposes certain features). Encapsulation controls the level of abstraction we want
to show to any outside source.
```cs
using System;

namespace RectangleArea {
   class Rectangle {
      //member variables
      internal double len;
      internal double wi;
      
      double RetArea() {
         return len * wi;
      }
      public void Output() {
         Console.WriteLine("The Length: {0}", len);
         Console.WriteLine("The Width: {0}", wi);
         Console.WriteLine("Area Output(Length*Width): {0}", RetArea());
      }
   }
   
   class ExecRectFunc {
      static void Main(string[] args) {
         Rectangle myRect = new Rectangle();
         myRect.len = 4.5;
         myRect.wi = 3.5;
         myRect.Output();
         Console.ReadLine();
      }
   }
}
```
As you can see I didn't provide an access modifier for the function RetArea. When the access modifier is not specified to a function defined within our class,
the function's access modifier defaults to private which is the case for RetArea. I used the keyword internal which means expose the values of the variable
only to functions and variables within the class.



* Abstraction: When something cannot exist directly it is said to be abstract. If you want to prevent people from creating Users directly you declare
the class Abstract. By doing this you force them to make a Student, Teacher, employee. You make the class abstract. If you try to create an instance of an
abstract class then you will get an error: Cannot create an instance of the abstract class. When it comes to methods in the base class declared abstract. You force
the derived classes to create their own implementation of the abstract method in the base class.

* Inheritance 

* Polymorphism: When things can morph from one type of object to another type of object thanks to Inheritance. So we have two classes Student and Teacher, a Student
is not a Teacher and a Teacher is not a Student. However, both Student and Teacher inherit from User or Person. The beauty of polymorphism is that it allows a
Student to be considered a Student or more generally a User. The same is true with Teacher, a Teacher can be considered a Teacher or more generally a User.
