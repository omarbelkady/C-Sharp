using System;

namespace Cust_Constructor
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
            Wr_L("Howdy Howdy y'all I just overrode the User meth and by I, I am the Student: "+TheFullName);
            // If you place () The member `Cust_Constructor.Student.TheFullName' cannot be used as method or delegate
            //If you do not it says object reference is required to access non-static member Student.TheFullName'
        }
        public string TheFullName{
            get{
                return FName+" "+LName;
            }
        }
        
        //Creating the custom constructor for Student
        public Student(string FN, string LN)
        {
            //I fix the error An object reference is required to access non-static member 
            //`Cust_Constructor.Student.TheFullName'
            /*By changing this:
            FN = FName;
            LN = LName;
            */
            //To This
            FName=FN;
            LName=LN;
        }
    }
}
