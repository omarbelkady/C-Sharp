using System;
using System.Collections.Generic;

namespace OptionalParams
{
    public class User
    {
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char
        
        public string TheFullName{
            get{
                return FName+" "+LName;
            }
        }
        
        public string FName{get;set;}
        public string LName {get;set;}
        
        //Creating the static Method
        public static void PrintMe(User user)
        {
            Wr_L("Static Method");
            user.outingToCons(2);
        }
        
        //Default num to 1 or any number we want
        public string outingToCons(int num=5)
        {
            string msg="";
            for(int j=0;j<num;j++)
            {
                msg += FName+ " " +LName+"\n";
            }
            return msg;
        }
        
        //Overloaded method. This one takes no parameters
        /*
        public string outingToCons()
        {
            return "My name is "+TheFullName;
        }
        */
    }
}
