using System;
namespace myAwesomeProg{
    class ArraySort {
        static void Main() {
            int [] studentGrades = {90,95,93,93,59};
            Array.Sort(studentGrades);
            for(int i=0;i<studentGrades.Length;i++)
            {
                Console.Write(studentGrades[i]+" ");
            }
        }
    }
}
