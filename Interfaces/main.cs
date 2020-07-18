using System;
using System.Collections.Generic;
using System.Linq;

namespace Interfaces
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
            Student myself = new Student("Omar","Belkady");
            myself.SomeThingToTheConsole();
            
            //We cannot create an instance of MeTalking(interface) we create an instance of the class that implements it
            MeTalking myInterf = new Student("Shut", "TF Up");
            myInterf.SomeThingToTheConsole();
            
            //To cast to a student to do a method
            MeTalking myInterf2 = new Student("Michelle", "Brinkley");
        }     
    }
}
