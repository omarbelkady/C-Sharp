using System; 
using System.Collections; 
  
class ArrList { 
  
    // Main Method 
    public static void Main(String[] args) 
    { 
  
        //ArrayList is the constructor to create an ArrayList 
        ArrayList omars = new ArrayList(); 
  
        Console.Write("Before Tacking on the Add Method:\n"); 
  
        
        Console.WriteLine("Let's see how many elements are in my ArrayList: "+omars.Count); 
  
        // Adding the elements 
        // to the ArrayList 
        omars.Add("Alan"); 
        omars.Add("is"); 
        omars.Add("A"); 
        omars.Add("6342_56837"); 
  
        Console.Write("After Tacking on the Add Method: "); 
  
        // Count property is used to get the 
        // number of elements in arrlist 
        Console.WriteLine(omars.Count);
        
        foreach(object elem in omars)
        {
            Console.Write(elem+" ");
        }
    } 
} 
