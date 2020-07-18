using System;

namespace Polymorphism
{
    //If you want to prevent people from creating Users directly
    //By forcing them to make a Student, Teacher, employee. You make the class abstract
    //If it is done then you will get an error: Cannot create an instance of the abstract class
    public class Student : User //Student Inherits From User
    {
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char 
        
        //Inherit and Override
        public override void overrideThisPlease()
        {
            Wr_L("Howdy Howdy y'all my I just overrode the User meth and by I, I am the Student: "+Student.TheFullName);
        }
        
        public static string TheFullName{
            get{
                return FaName+" "+LaName;
            }
        }
        public static string FaName{get;set;}
        
        public static string LaName {get;set;}
    }
}
