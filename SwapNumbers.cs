using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class SwapNumbers
    {
        public static void Swap()
        {
            string str1 = "Rishi";
            string str2 = "Rio";
            Console.WriteLine("Before Swapping \nInput1 = " + str1+"\nInput2 = " + str2);
            (str1, str2) = Swaped(str1, str2);
            Console.WriteLine("Input 1 = " + str1 + "\nInput 2 = " + str2);

                }

        public static (T,T) Swaped<T>(T input1,  T input2)
        {
            T temp = input1;
            input1 = input2;
            input2 = temp;

            return (input1, input2);
        }
    }
}
