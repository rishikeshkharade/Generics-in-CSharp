using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericsClass
    {
        public static void GenericsClassMain()
        {
            int[] intArr = { 1, 2, 3, 4, 5, };
            char[] charArr = { 'a', 'b', 'c', 'd' };
            double[] doubleArr = { 1.2, 3.2, 7.8, 9.0 };
            string[] strArr = { "Rishikesh", "Ashok", "Kharade" };
            ToPrint(intArr);
            ToPrint(charArr);
            ToPrint(doubleArr);
            ToPrint(strArr);
        }
        public static void ToPrint<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item+" Generic");
            }
        }
    public static void ToPrint(int[] intarray)
            {
                foreach (int elements in intarray)
                {
                    Console.WriteLine(elements +" Not Generic");
                }
            }
        }
    }
