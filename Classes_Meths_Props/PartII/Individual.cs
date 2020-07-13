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
        
        public bool isAnnoying(bool val)
        {
            if(val)
            {
                Console.WriteLine(FName+" "+ LName+" is indeed annoying");
            }
            
            else if(!val)
            {
                Console.WriteLine(FName+" "+ LName+" is not annoying");
            }
            
            return val;
        }
        
        
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
        
        static void Main()
        {
            //Individual eliya;
            //The above line of code will generate a null reference exception
            //because the constructor was not called
            Individual eliya= new Individual();
            
            eliya.FName="Eliya";
            eliya.LName="Roberts";
            Console.WriteLine(eliya.myFullN());
            eliya.isAnnoying(false);
            
        }
    }
}
