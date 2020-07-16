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
        
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char
        
    }
}
