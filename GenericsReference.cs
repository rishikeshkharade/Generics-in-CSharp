using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericsReference
    {
        public static void ClsMain()
        {
            bool IsEqual = ClsCalculator.AreEqual<string>("Rishi", "Rishi");
            if (IsEqual)
            {
                Console.WriteLine("Value is Equal");
            }
            else
            {
                Console.WriteLine("Values are not Equal");
            }

            Console.ReadKey();
        }
    }

    public class ClsCalculator
    {
        public static bool AreEqual<T>(T value1, T value2)
        { return value1.Equals(value2); }
    }
}
