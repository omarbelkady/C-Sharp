using System;

namespace SetterCreation
{
    public class Uni_Student
    {
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char
       
        string _myFirstName;
        //If you didn't put an empty string there will be an NullReferenceException error raised
        //You must either put a value or an empty space
        
        public string FirstName
        {
            
            //Not all code paths return a value will be the error raised if no return in get method 
            get
            {
                return _myFirstName.ToUpper();//stored now as all UPPER CASE
            }
            
            //Creating The set method
            set{
                _myFirstName=value;
                //The value is going to contain whatever the person assigns to it.
            }
            
        }
        public string LastName {get;set;}
        public string Major {get;set;}
        public int Year {get;set;}
        
        
        public string outingToCons(int num)
        {
            string msg="";
            for(int j=0;j<num;j++)
            {
                msg += FirstName+ " " +LastName + " "+ Year+"\n";
            }
            return msg;
        }
        
        
        
    }
}
