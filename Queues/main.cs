using System; 
using System.Collections; 
  
class GFG { 
  
    // Driver code 
    public static void Main() 
    { 
  
        // Creating a Queue 
        Queue omarsQ = new Queue(); 
  
        // Inserting the elements into the Queue 
        omarsQ.Enqueue("CS"); 
        omarsQ.Enqueue("CE"); 
        omarsQ.Enqueue("Accounting"); 
        omarsQ.Enqueue("Finance"); 
        omarsQ.Enqueue("Mechanical Engineering"); 
        omarsQ.Enqueue("Aerospace Enginering"); 
  
        // Displaying the count of elements 
        // contained in the Queue 
        Console.Write("Total number of elements in the Queue are : "); 
  
        Console.WriteLine(omarsQ.Count);
        
        //How to iterate throu a Queue
        foreach(object j in omarsQ)
        {
            Console.WriteLine(j);
        }       
    } 
}
