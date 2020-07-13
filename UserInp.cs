using System;
namespace UserInp{
    class UserInp {
      static void Main() {
        //I will now store the output in a variable
        var inp=Console.ReadLine();
        //Return Value(Console.ReadLine() is assigned to inp)
        // Console.ReadLine();//Method that returns a string
        Console.WriteLine("Hello World");//void
        Console.WriteLine(inp);
        
        var mine=Console.ReadLine();
        //String interpolation
        Console.WriteLine($"This is {mine} man!");
      }
    }
}
