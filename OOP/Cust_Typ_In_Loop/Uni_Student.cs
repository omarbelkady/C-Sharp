using System;

namespace Cust_Typ_In_Loop
{
    public class Uni_Student
    {
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char
        
        public string FName{get;set;}
        public string LName {get;set;}
        
        public string TheFullName{get{return FName+" "+LName;}}
        
        public string Major {get;set;}
        public int Year {get;set;}
    }
}
