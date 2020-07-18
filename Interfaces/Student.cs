using System;

namespace Interfaces
{    
    public class Student : User, MeTalking //Student Inherits From User and Implements MeTalking
    {
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char 
        
        //Creating the custom constructor for Student that is read only
        //To invoke I put a colon
        public Student(string FN, string LN): base (FN,LN)
        {
            
        }
        public int MakeSth{get; set;}
        
        public override void SomeThingToTheConsole()
        {
            Wr_L("Howdy Howdy y'all I just overrode the User meth and by I, I am the Student: "+TheFullName);
            // If you place () The member `Cust_Constructor.Student.TheFullName' cannot be used as method or delegate
            //If you do not it says object reference is required to access non-static member Student.TheFullName'
        }
    }
}
