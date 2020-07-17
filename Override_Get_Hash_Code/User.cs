using System;
using System.Collections.Generic;

namespace Override_GetHashCode
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
        
        //Remember The data Structure Hash Table ≈ The hash table is a DS
        //which permits us to store information. Hash Table have what's called
        //a hash function. It is used to compute an index where the value can be
        //found at.

        //Obtaining hash Code method is useful for only to put our object in a hash table
        //If you're not planning to do that just do this:
        /*
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        */
        
        //We have to create a method that determines  whether 
        //an object has already been put into a hash code.
        //This is because it will have the same hashed value.
        public override int GetHashCode()
        {
            return TheFullName.GetHashCode();
            //Hashing works like this: if we take the same input and run it through
            //the function the ouput will be the same everytime. If two obj have 
            //the same Full Name therefore the hash function should give us the same value
            
        }
        
        public override bool Equals(object myObj)
        {
            //return base.Equals(myObj);
            //Casting myObj to User
            if(TheFullName == ((User)myObj).TheFullName)
            //This is saying if two Users have the same name then they are
            //the same entity
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
            //Error generated if you do not put the base case:
            //Not all code path return a value generated to overcome this do this:
            return -1;//MEANING NOT FOUND
        }
        //Overloading the Find Method as you can see the return type is the same 
        //BUT THE PARAMETERS ARE NOT
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
    }
}
