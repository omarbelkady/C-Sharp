using System;
using System.Globalization;

namespace Date_Display{
    public class Date_Display{
        
        public static void RunMyProg()
        {
            var date1 = new DateTime(2020, 07, 20, 23, 14, 40);
            Console.WriteLine(date1.ToString());
            
        }
        
        public static void Main(string [] args)
        {
            RunMyProg();
        }
            
    }
}
