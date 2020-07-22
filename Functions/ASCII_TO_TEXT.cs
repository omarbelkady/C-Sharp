using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_TO_TEXT
{
    class ASCII_TO_TEXT
    {
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char
        
        public static void Run()
        {
            Wr_L("Enter Any String of Text: ");
            string asci_to_text = Console.ReadLine();
            byte [] myarray= Encoding.ASCII.GetBytes(asci_to_text);
            foreach(byte j in myarray)
            {
               Console.WriteLine("{0} = {1}", j,(char)j);
            }
        }
        static void Main(string[] args)
        {
            // Display the number of command line arguments.
            Run();
        }
        //65 108 97 110 32 76 111 118 101 115 32 67
    }
}
