using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_To_ASCII
{
    class Text_To_ASCII
    {
        static void Wr_L(object o)=>Console.WriteLine(o);//Includes a new line char
        
        static void Wr_i(object m)=>Console.Write(m);//Includes a new line char
        
        public static void Run()
        {
            var A = 'A';
            Wr_L($"ASCII value of {A} => {(int)A}");//65_76_97_78_32_108_79_86_69_83_32_67
            var L = 'L';
            Wr_L($"ASCII value of {L} => {(int)L}");
            
            var a = 'a';
            Wr_L($"ASCII value of {a} => {(int)a}");
            
            var N = 'N';
            Wr_L($"ASCII value of {N} => {(int)N}");
            
            var space1 = ' ';
            Wr_L($"ASCII value of {' '} => {(int)space1}");
            
            var l = 'l';
            Wr_L($"ASCII value of {l} => {(int)l}");
            
            var O = 'O';
            Wr_L($"ASCII value of {O} => {(int)O}");
            
            var V = 'V';
            Wr_L($"ASCII value of {V} => {(int)V}");
            
            var E = 'E';
            Wr_L($"ASCII value of {E} => {(int)E}");
            
            var S = 'S';
            Wr_L($"ASCII value of {S} => {(int)S}");
            
            var space2 = ' ';
            Wr_L($"ASCII value of {' '} => {(int)space2}");
            
            var C = 'C';
            Wr_L($"ASCII value of {'C'} => {(int)C}");
            
        }
        static void Main(string[] args)
        {
            // Display the number of command line arguments.
            Run();
        }
    }
}
