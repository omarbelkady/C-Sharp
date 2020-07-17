using System;
using System.Collections.Generic;


namespace OverrideToString
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
            //Whenever you Console.WriteLine and I pass in an Object it will by default
            //Call the ToString
            //User will by default inherit from Object. And one of the elements within Object is ToString
            //Then within the User Class we can create our own method ToString and 
            //When we create a User and give him a name and call the ToString Method on it
            
            User myself = new User();
            myself.FName= "Omar";
            myself.LName = "Belkady";
            
            Wr_L(myself.ToString());// This is redundant because ToString is called by default
             
        }
        
    }
}
