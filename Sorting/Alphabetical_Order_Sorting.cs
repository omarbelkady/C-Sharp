using System;
using System.Linq;
//Must use library or else error raised: does not contain a definition for `OrderBy'
namespace Main{
    class Alphabetical_Order_Sorting{
        static void Main() {
            var seconds = 160000;
            Wr_L("Insert Words Separated By a Comma For Them To Be Sorted In Alphabetical Order");
            var text = Console.ReadLine();
            var words= text.Split(',').OrderBy(x=>x);
            var sorted_Text=string.Join(",",words);
            Wr_L(sorted_Text);
            Console.ReadKey();
        }
        
        
        static void Wr_L(object n)
        {
            Console.WriteLine(n);
        }
        
        static void Wr_i(object j)
        {
            Console.Write(j);
        }
    }
}

