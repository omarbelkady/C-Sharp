using System;
using System.Collections.Generic;

namespace OptionalParams
{
    class MyProg
    {
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char
        
        static void Main(){
            MyProg firstProg = new MyProg();//Creating an object
            firstProg.printing();
        }
        
        public void printing()
        {
            User max= new User();//Instance identifier
            max.FName= "Max";//Identifier.methodName
            max.LName= "Versatile";
            
            User richard= new User();//Instance identifier
            richard.FName= "Richard";//Identifier.methodName
            richard.LName= "Jones";
            
            //How to invoke the overloads
            Wr_L(max.outingToCons());//prints 5 by default
            Wr_L(richard.outingToCons(6));
        }
    }
}
