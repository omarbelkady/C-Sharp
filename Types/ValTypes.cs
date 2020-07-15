using System;
namespace ValTypes{
    class ValTypes {
        static void Main(string [] args) {
            //if I have a variable and that is of value type
            //it directly contains whatever I assign to it.
            int a = 16;
            
            //In contrast, a reference type just stores
            //a reference to whatever I am trying to store
            
            //Sometimes what we want to store is very very large.
            //Imagin I had a collection of vals e.g. array
            //I had 10000+ numbers. If I created a variable to store that
            //and I created more vars to reference the array by. If this was
            //a value type it would have to copy the entire array.
            
            //Since, we can have a reference, we can reference this many 
            //times. IT will always point to the same destination in memory.
            
            //Now here the difference in mutability
            //If I set the value of a to 16
            //Then set the value of a to b
            //And then changed the value of b
            //A would be the same and not have changed. 
            
            //However, if I declared an array a and stored some numbers in it
            //Then I assigned array b to array a. Both array would point to the giant array
            int b=a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            
            b=3;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
