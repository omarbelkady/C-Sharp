


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
