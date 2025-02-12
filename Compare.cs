using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Compare
    {
        public static void DifferentValues()
        {
            Console.WriteLine("Enter the Values to Comapre");
            int result = CompareValues(Console.ReadLine(), Console.ReadLine());
            /*CompareValues(20, 30);
            CompareValues(10, 10);

            CompareValues(20.5, 20.5);
            CompareValues(10.20, 20.5);
            CompareValues(30.5, 20.00);


            CompareValues("apple", "banana");
            CompareValues("Rishi", "Rishi");
            CompareValues("Rahul", "Sanket");*/
            


            if (result == -1) Console.WriteLine("Value 1 is Less than Value 2");
            else if (result == 1) Console.WriteLine("Value 1 is Greater than Value 2");
            else Console.WriteLine("Values are Equal");
                

            Console.ReadKey();
        }

        public static int CompareValues<T>(T input1, T input2) where T : IComparable<T>
        {
            return input1.CompareTo(input2);
        }
    }
}
