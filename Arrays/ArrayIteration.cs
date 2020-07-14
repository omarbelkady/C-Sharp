using System;
namespace Arrays{
    class ArrayIteration
    {
        static void Main()
        {
            //Array Declaration 4 is the actual size we can store 4 elements
            string [] letterGrade = new string[4];
            letterGrade[0]="Alpha";
            letterGrade[1]="Beta";
            letterGrade[2]="Gamma";
            letterGrade[3]="Delta";
            
            foreach(string a in letterGrade)
            {
                Console.WriteLine(a);
            }
        }
    }
}
