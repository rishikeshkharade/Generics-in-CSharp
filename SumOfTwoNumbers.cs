using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class SumOfTwoNumbers
    {
        public static void SumOfTwoNumbersMain()
        {
            int a = 10, b = 20;
            double input1 = 10.2555, input2 = 536.22;
            
            Console.WriteLine("Sum of integers: " + Calulation(a, b));
            Console.WriteLine("Sum of Doubles: " + Calulation(input1, input2)); 
        }

        public static T Calulation<T>(T a, T b)
        {
            return (dynamic)a + b;
        }
    }

}
