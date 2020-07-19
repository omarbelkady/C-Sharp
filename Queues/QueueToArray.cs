using System; 
using System.Collections; 
namespace QueueToArray{
    class Bla{ 
		public static void Main() 
		{
			// Creating a Queue 
			Queue coolPeeps = new Queue(); 

			// Inserting the elements into the Queue 
			coolPeeps.Enqueue("Alan"); 
			coolPeeps.Enqueue("Angela"); 
			coolPeeps.Enqueue("Waleed"); 
			coolPeeps.Enqueue("Nelan"); 
			coolPeeps.Enqueue("Nouhaila"); 
			coolPeeps.Enqueue("2526_Is_A_C_And_Pascal_Lover"); 

			//Converting the newly created Queue into an Array
			Object [] ra = coolPeeps.ToArray();

			//Sorting the array by calling the Array.Sort method
			Array.Sort(ra);

			//How to iterate throu a Queue
			for(int j=0;j<ra.Length;j++)
			{
				Console.WriteLine(ra[j]+" ");
			}

			Console.WriteLine("\nReversing it: ");
			Array.Reverse(ra);
			foreach(object l in ra)
			{
				Console.WriteLine(l);
			}
		} 
	} 
}
