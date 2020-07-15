using System;
using System.Collections.Generic;
namespace Reftypes{
    class Reftypes {
        static void Main(string [] args) {
            //Now I will use an Array which is a Reference Type
            int [] reftyp = {6,51,4};
            int [] copyOfRefTyp=reftyp;//This means that both reftyp and copyOfRefTyp point to the same array
            Console.WriteLine(reftyp[0]);
            Console.WriteLine(copyOfRefTyp[0]);
            
            reftyp[2]=5;
            Console.WriteLine("This is Normal: "+reftyp[2]);
            Console.WriteLine("But Wait???: " + copyOfRefTyp[2]+ "\nThe value above should be 4!");
            
            //This is because when we make a change to reftyp these changes are reflected on copyOfRefTyp
            //BECAUSE copyOfRefTyp is a Reference Type
        }
        
        static void meth2(int [] reftyp)
        {
            reftyp[0]=9;
        }
    }
}
