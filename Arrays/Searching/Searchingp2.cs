using System;
namespace myAwesomeProg{
    class Arrays {
        static void Main() {
            int [] studentGrades = {90,95,93,93,59};
            Console.WriteLine(Array.IndexOf(studentGrades,93));//prints 2
            Console.WriteLine(Array.IndexOf(studentGrades,92));//Prints -1 because not found
        }
    }
}
