using System;
using System.Collections.Generic;
using System.Linq;

namespace Inheritance
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
            Student omar = new Student();
            Student.FName = "Omar";
            Student.LName = "Belkady";
            omar.User_Is_Verified = true;
            Wr_L(Student.TheFullName);
            /*if(omar.User_Is_Verified && alan.User_Is_Verified)
            {
                Wr_L("Omar and Alan-6342_56837 is Verified");
            }
            */
            //Using the conditional above will raise local variable `alan' cannot be used before it is declared
            
            Student alan = new Student();
            Student.FName = "Alan";
            Student.LName = "Ngo";
            alan.User_Is_Verified = true;
            Wr_L(Student.TheFullName);
            
            if(omar.User_Is_Verified && alan.User_Is_Verified)
            {
                Wr_L("Both Omar and Alan-6342_56837 are Verified");
            }
        }     
    }
}
