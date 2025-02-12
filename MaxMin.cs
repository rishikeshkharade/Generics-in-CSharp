using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MaxMin
    {
        public static void MaxMinMain()
        {
            
            Console.WriteLine("Maximum Element " + FindMax(10.5f, 80.2f, 30.6f));
            Console.WriteLine("Maximum Element " + FindMax(15.222d, 65.222d, 569.2050d));
            Console.WriteLine("Maximum Element " + FindMax(10, 20, 30));

            Console.WriteLine("Minimum Element " + FindMin(10.5f, 80.2f, 30.6f));
            Console.WriteLine("Minimum Element " + FindMin(15.222d, 65.222d, 569.2050d));
            Console.WriteLine("Minimum Element " + FindMin(10, 20, 30));
        }
        public static T FindMax<T>(T input1, T input2, T input3) where T : IComparable<T>
        {
            T max = input1;
            if (input2.CompareTo(max) > 0) max = input2;
            if (input3.CompareTo(max) > 0) max = input3;
            return max;
        }

        public static T FindMin<T>(T input1, T input2, T input3) where T : IComparable<T>
        {
            T min = input1;
            if (input2.CompareTo(min) < 0) min = input2;
            if (input3.CompareTo(min) < 0) min = input3;
            return min;
        }
    }
}
