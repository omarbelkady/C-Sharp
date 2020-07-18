using System;
using System.Collections.Generic;
using System.Linq;

namespace Polymorphism
{
    public abstract class User
    {
        
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
        
        //I replace virtual with abstract. Both virtual and abstract allow us to override.
        //But abstract has one bottom line. When creating an abstract method IT CANNOT HAVE A body
        public abstract void overrideThisPlease();
    }
}
