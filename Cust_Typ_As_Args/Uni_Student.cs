using System;

namespace Cust_Typ_As_Args
{
    public class Uni_Student
    {
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char
        
        public string FName{get;set;}
        public string LName {get;set;}
        
        public string TheFullName{
            get{
                return FName+" "+LName;
            }
        }
        
        public string Major {get;set;}
        public int Year {get;set;}
        
        
        /*public string outingToCons(int num)
        {
            string msg="";
            for(int j=0;j<num;j++)
            {
                msg += FName+ " " +LName + " "+ Year+"\n";
            }
            return msg;
        }
        */
    }
}
