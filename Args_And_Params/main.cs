using System;

namespace ParameterizingMyMethods
{
    class MyProg
    {
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char
        
        static void Main(){
            MyProg firstProg = new MyProg();//Calling the constructor
            firstProg.printing();
        }
        
        public void printing()
        {
            Uni_Student Alan= new Uni_Student();
            Alan.FirstName = "Alan";
            Alan.LastName= "Ngo";
            Alan.Identification_Number= 2056837;
            Alan.Major= "CS with a C-Language Concentration!";
            Alan.Year=4;
            Alan.PrintingSth(3);//3 is Arg
        }
    }
}
