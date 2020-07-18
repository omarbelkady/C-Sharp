using System;
using System.Collections.Generic;

namespace RefTypeVsValType
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
             
             
            
            //As you can the increment didn't affect myVar;
            //But when we work with an object its different
            //Because when we work with objects we are working 
            //with a reference to the object and not the value
            User nelan = new User();
            nelan.FName= "Alan";
            dumbMethod(nelan);
            Wr_L(nelan.FName);
            
            User jessica = new User();//Unexpected symbol gets triggered if you forget to place semi-colon
            jessica.FName="Jessica";
            dumbMethod(jessica);
            Wr_L(jessica.FName);
        }
        
        /*
        //Creating a method
        public void dumbMethod(int i)
        {
            i++;
        }
        
        //int myVar= 401;
            
        //dumbMethod(myVar);
        //Wr_L(myVar);
        */    
        
        public void dumbMethod(User j)
        {
            j.FName="Jerry";
        }
        
        //as you can see Jerry was printed and not Alan
        
        public void Testing123(User l)
        {
            l=new User();
            l.FName="Louisa";
        }
    }
}
