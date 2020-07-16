using System;

namespace ParameterizingMyMethods
{
    public class Uni_Student
    {
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char
        
        //I create a property
        //public object MyProp{get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public int Identification_Number {get;set;}
        public string Major {get;set;}
        public int Year {get;set;}
        
        
        //<------HOW MANY TIMES DO YOU WANT ME TO PRINT YOUR INFO
        //numOfTimes is a Param
        public void PrintingSth(int numOfTimes)//Method Naming is Pascal Case first Letter of Every Word is Capital
        {
            for(int i=0;i<numOfTimes;i++)
            {
                Wr_L(FirstName+" "+LastName+" has an id of: "+Identification_Number+" and majors in: "+Major+" and is in his "+Year+"(th) year of University");
            }
                
        }
    }
}
