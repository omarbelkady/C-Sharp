using System;
using System.Collections.Generic;
using System.Linq;

namespace Cust_Constructor
{
    public abstract class User
    {
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char
        
        public User()
        {
            Wr_L("You know what I get printed out first because Student inherits from me!");
        }
        
        public bool User_Is_Verified{get;set;}=false;
        
        public static string FName{get;set;}
        
        public static string LName {get;set;}
    
        public abstract void overrideThisPlease();
    }
}
