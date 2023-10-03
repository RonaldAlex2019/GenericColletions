using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTest
{
    public static class OverloadedMethods
    {
        public static void DisplayArrray(int[] inptArray)
        {
            foreach (var item in inptArray)
            {
                
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine();
        }


        public static void DisplayArrray(double[] inptArray)
        {
            foreach (var item in inptArray)
            {

                Console.WriteLine($"{item} ");
            }
            Console.WriteLine();
        }

        public static void DisplayArrray(char[] inptArray)
        {
            foreach (var item in inptArray)
            {
                
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
