using System;
using System.Collections.Generic;

namespace Lists_Of_Cust_Typ
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
            Uni_Student daniel= new Uni_Student();
            daniel.FName= "Daniel";
            daniel.LName= "Brando";
            daniel.Year=3;
            
            
            Uni_Student Daniela= new Uni_Student();
            Daniela.FName = "Daniela";
            Daniela.LName = "Morales";
            Daniela.Year = 4;
            
            //Creating the List OF Custom Type Uni_Student
            List<Uni_Student> uniStudents = new List<Uni_Student>();
            uniStudents.Add(daniel);
            uniStudents.Add(Daniela);
            
            foreach(Uni_Student stud in uniStudents)
                Wr_L(stud.TheFullName);
                //Without the .TheFullName it will print Lists_Of_Cust_Typ which is the name of the namespace
        }
    }
}
