using System;
using System.Collections.Generic;

namespace MyAwesomeProg{
    class Indexing {
        static void Main() {
            List<int> studGrades= new List<int>(){87,94,92,101,89,89,89,89,200};
            /*Boolean Output
            if(studGrades.Contains(89))
            {
                Wr_L("Found It!");
            }
            */
            //Comparison
            if(studGrades.IndexOf(200) == 5)
            {
                Wr_L("Correct Correlation");
            }
            else
            {
                Wr_L("Incorrect Correlation");
            }
            
            if(studGrades.LastIndexOf(89)==7)
            {
                Wr_L("Correct Guess");
            }
        }
		
		//Thank you for showing me this 6342 56837
        static void Wr_L(object o)
        {
            Console.WriteLine(o);
        }
        
        static void Wr_i(object m)
        {
            Console.Write(m);
        }
    }
}
