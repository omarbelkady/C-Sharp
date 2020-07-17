using System;
using System.Collections.Generic;


namespace OverrideEqualsNdToString
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
            myself.FName = "Omar";
            myself.LName = "Belkady";
            
            User him = new User();
            him.FName = "Omar";
            him.LName = "Belkady";
            
            //Wr_L(myself.ToString());// This is redundant because ToString is called by default
            
            //How to call the .Equals I pass in the object and the method will logically 
            //Compare the two objects and see if they are equal
            Wr_L(myself.Equals(him));//Output is false even though the values are the same    
        }
    }
}
