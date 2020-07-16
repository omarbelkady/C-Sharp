using System;
using System.Collections.Generic;
using System.Linq;

namespace myAwesomeProg{
    class The_Best_Prog {
    
        static void Main(){
            The_Best_Prog my_Obj= new The_Best_Prog();//Instantiation of an object
            my_Obj.printHello();
        }
        
        public void printHello()
        {
            Wr_L("Hello There Everyone");
            MyClass strawBerry= new MyClass();
        }
        
        
        static void Wr_L(object o)//Includes a new line char
        {
            Console.WriteLine(o);
        }
        
        static void Wr_i(object m)//DOESN't
        {
            Console.Write(m);
        }
        
    }
}
