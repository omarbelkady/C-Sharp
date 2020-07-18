using System;
using System.Collections.Generic;
using System.Linq;

namespace Abstract_Methods
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
            
            Student alan = new Student();
            Student.FName = "Alan";
            Student.LName = "Ngo";
            alan.User_Is_Verified = true;
            Wr_L(Student.TheFullName);
            alan.overrideThisPlease();
        }     
    }
}
