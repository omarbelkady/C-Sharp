using System;
using System.Collections.Generic;

//Whenever you pass objects to methods or returning objects from methods.


namespace RefTypeVsValType
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
        
        public override string ToString()
        {
            return TheFullName;
        }
        
        public override int GetHashCode()
        {
            return TheFullName.GetHashCode();
            
            
        }
        
        public override bool Equals(object myObj)
        {
            
            if(TheFullName == ((User)myObj).TheFullName)
            
            {
                return true;
            }
            
            return false;
        }
        
        //Creating the static Method
        public static void PrintMe(List<User> users)
        {
            foreach(User user in users)
            {
                Wr_L(user.ToString());
            }
        }
        
        //Creating the static Method
        public static void PrintMe(User user)
        {
            Wr_L("Static Method");
            user.outingToCons(2);
        }
        
        public string outingToCons(int num=5)
        {
            string msg="";
            for(int j=0;j<num;j++)
            {
                msg += FName+ " " +LName+"\n";
            }
            return msg;
        }
    
        public static int Find(List<User> users, string FuName)
        {
            for(int i=0;i<users.Count;i++)
            {
                if(users[i].TheFullName==FuName)
                {
                    return i;
                }
            }
            
            return -1;//MEANING NOT FOUND
        }
        
        public static int Find(List<User> users, User user)
        {
            for(int i=0;i<users.Count;i++)
            {
                if(users[i].Equals(user))
                {
                    return i;
                }
            }
            //Error generated if you do not put the base case:
            //Not all code path return a value generated to overcome this do this:
            return -1;//MEANING NOT FOUND
        }
        
        //The Method below returns a User and takes a list of type User named users
        //And takes a User object named user
        public static User ReturnMeTheUserFromTheList(List<User> users, User user)
        {
            //Search
            foreach(User fer in users)
            {
                if(fer.Equals(user))
                //if the user passed in matches the particular user
                // fer then give back that user from the list
                {
                    return fer;
                }
            }
            //we must return a value
            return null;
        }
    }
}
