using System;

namespace ReturnStatement
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
            Uni_Student Nouhaila= new Uni_Student();
            Nouhaila.FirstName = "Nouhaila";
            Nouhaila.LastName= "Bla";
            Nouhaila.Identification_Number= 491192;
            Nouhaila.Hobby= "CE";
            Nouhaila.Year=2;
            Nouhaila.Hobby= "Swimming";
            Wr_L(Nouhaila.PrintingSth(2));
        }
    }
}
