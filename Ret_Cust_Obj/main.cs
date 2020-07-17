using System;
using System.Collections.Generic;

namespace Ret_Cust_Obj
{
    class MyProg
    {
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char
        
        static void Main(){
            MyProg firstProg = new MyProg();//Creating an object
            firstProg.printing();
        }
        
        public void printing()
        {
            
            User myself = new User();
            myself.FName= "Omar";
            myself.LName = "Belkady";
            
            User him = new User();
            him.FName= "Nelan";
            him.LName = "IsACLover";
            
            List<User> users = new List<User>() {myself,him};
            
            //User We are Searching For
            User search = new User();
            search.FName = "Nelan";
            search.LName = "IsACLover";
            
            Wr_L(User.ReturnMeTheUserFromTheList(users, search));
            //This returns the full name because it will search for the first name and 
            //call the ToString method which spits out the whole name
            
            
            //By adding three nnn to FName in search it evaluates to null and prints the string
            if(User.ReturnMeTheUserFromTheList(users, search)== null)
            {
                Wr_i("Not Found You Mong");
            }    
            //REMEMBER WE ARE RETURNING A USER OBJECT
        }
    }
}
