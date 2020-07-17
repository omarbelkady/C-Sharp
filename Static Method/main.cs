//When Something is Static it is attached to the Class rather than
//an instance of a class/Object. An instance method is attached to the instances of the class/objects of the class. 
//We define a class and then we create instances of the class
//which are known as objects. When you define a method in the class. Everytime you
//instantiate the class into an object the method is made available
using System;
using System.Collections.Generic;


namespace Static_Methods
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
            User.PrintMe(max);
            
        }
        //Anytime we pass in objects they are modifiable
        //We can change objects but we cannot assign new objects
    }
}
