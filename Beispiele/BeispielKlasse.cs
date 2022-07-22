using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beispiele
{
    public static class BeispielKlasse
    {
        //Pass by value
        public static void BeispielFunktion1(int a)
        {
            a = 10;
        }
        

        //Pass by reference 
        public static void BeispielFunktion2(IntWrapper intWrapper)
        {
            intWrapper.Moehre = 42; 
        }

        public static void BeispielFunktion4(ref int a)
        {
            a = 10;
        }

        public static int BeispielFunktion5(int a)
        {
            a = a * 2;
            return a;
        }
        public static void BeispielFunktion6(ref int a)
        {
            a = a * 2;
        }
    }
}
