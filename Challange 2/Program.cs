using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char myChar = 'A';
            char myChar2 = 'a';

            int myValue = Convert.ToInt32(myChar);
            int myValue2 = Convert.ToInt32(myChar2);

            string myString = "This Is my charcter A value";
            string myString2 = "This Is my charcter a value";

            Console.WriteLine("{0} = {1} and {2} = {3}", myString, myValue, myString2, myValue2);
            Console.ReadKey();

        }
    }
}
