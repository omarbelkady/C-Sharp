using System;
namespace Classes{
    public class Individual
    {
        //We can put properties, fields, methods, etc. here
        //I will create a property of type boolean isAnnoying
        //Properties store things and are used to access data from the outside
        //A Field is used to store data in the inside
        //Field naming is always camel case
        //MEthod naming is pascal case
        
        public string FName{get; set;}//property A
        public string LName{get; set;}//property B
        
        /*public bool isAnnoying(bool val)
        {
            val=true;
        }
        */
        
        //property
        public string retFullNam{
            get{
                return FName+" "+LName;
            }
        }
        
        //This is a method it does sth
        public string myFullN(){
            return FName+" "+LName;
        }
    }
}
