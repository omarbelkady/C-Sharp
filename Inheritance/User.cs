using System;
using System.Collections.Generic;
using System.Linq;

namespace Inheritance
{
    public class User
    {
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char
        
        public bool User_Is_Verified{get;set;}=false;
        
        
        //Making it static to prevent it from being overriden and prevent the error
        //An object reference is required to access non-static member 
        //`Inheritance.User.TheFullName
        public static string TheFullName{
            get{
                return FName+" "+LName;
            }
        }
        
        //Making it static to prevent it from being overriden and prevent the error
        public static string FName{get;set;}
        
        //Making it static to prevent it from being overriden and prevent the error
        public static string LName {get;set;}
    }
}
