using System;
namespace myAwesomeProg{
    class Arrays {
        static void Main() {
            int [] studentGrades = {90,95,93};
            
            bool foundItem=false;
            
            for(int i=0;i<studentGrades.Length;i++)
            {
                //Searching an Array
                if(studentGrades[i] ==95)
                {
                    Console.Write("Located!");
                    foundItem=true;
                    break;
                }
            }
            if(!foundItem)
            {
                Console.WriteLine("Not Found");   
            }
        }
    }
}
