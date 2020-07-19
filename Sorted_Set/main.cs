//Sorted Set elements must be unique
//Sorted Set sorts elements in ascending order
using System; 
using System.Collections.Generic; 
  
class SortedSet{
    public static void Main() 
    {
        //Instantiate a Sorted Set
        SortedSet<int> omars_Set = new SortedSet<int>(); 
  
        //Pushing elements to  
        omars_Set.Add(68); 
        omars_Set.Add(98); 
        omars_Set.Add(32); 
        omars_Set.Add(1); 
        omars_Set.Add(1174); 
        Console.WriteLine("Elements of omars_Set:"); 
  
        foreach(var elem in omars_Set) 
        { 
            Console.WriteLine(elem); 
        }
  
        //Creating a sorted setwith initial values
        SortedSet<int> omars_Set2 = new SortedSet<int>() { 
                                98,9,909,45}; 
        
        Console.WriteLine("Elements of my_Set2:"); 
        foreach(var valu in omars_Set2) 
        { 
            Console.WriteLine(valu); 
        }
        
        //To remove an element from a set call the .Remove method with the value you want to remove
        omars_Set2.Remove(909);
        Console.WriteLine("Updated omars_Set2: ");
        
        //Unexpected symbol `foreach' means you forgot a semi-colon
        foreach(var updSet2 in omars_Set2)
        {
            Console.WriteLine(updSet2);
        }
        
        
        //Checking whether an element exists
        if(omars_Set2.Contains(909) == true)
        {
            Console.WriteLine("Element Exists");
        }
        
        else
        {
            Console.WriteLine("Element is not there");
        }
        //Empty out the set
        omars_Set2.Clear();
        
        Console.WriteLine("The total number of elements within the set after performing the .Clear method:{0}", omars_Set2.Count);
    } 
}
