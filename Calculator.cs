using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Calculator
    {
        public static void CalculatorMain()
        {
            Console.WriteLine("Welcome to Calculator\nPlease Choose the option below");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Value 1");
            double value1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Value 2");
            double value2 = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addition of Two Numbers = " + Addition(value1, value2));
                    break;

                case 2:
                    Console.WriteLine("Subtraction of Two Numbers = " + Subtraction(value1, value2));
                    break ;

                case 3:
                    Console.WriteLine("Multiplication of Two Numbers = " + Multiplication(value1, value2));
                    break ;

                case 4:
                    Console.WriteLine("Divisoin of Two Numbers = " + Division(value1, value2));
                    break ;

                case 5:
                    return;

                    default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
        public static double Addition<T>(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }

        public static double Subtraction<T>(T a, T b)
        {
            return (dynamic)a - (dynamic)b;
        }

        public static double Multiplication<T>(T a, T b)
        {
            return (dynamic)a * (dynamic)b;
        }

        public static double Division<T>(T a, T b)
        {
            return a / (dynamic)b;
        }
    }
}
