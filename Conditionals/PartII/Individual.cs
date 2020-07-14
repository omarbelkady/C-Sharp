using System;
namespace Conditionals{
    public class Individual
    {
        
        public string FName{get; set;}//property A
        public string LName{get; set;}//property B
        
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
