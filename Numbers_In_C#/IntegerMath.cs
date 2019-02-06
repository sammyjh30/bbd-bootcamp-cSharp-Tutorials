using System;

namespace Numbers_In_C_
{
    class Program
    {
        static void IntegerMath()
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);
            c = a - b;
            Console.WriteLine(c);
            c = a * b;
            Console.WriteLine(c);
            c = a / b;
            Console.WriteLine(c);
            c = a + b;
            Console.WriteLine(c);
        }

        static void OrderOfOperands()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            a = 5;
            b = 4;
            c = 2;
            d = (a + b) * c;
            Console.WriteLine(d);

            a = 7;
            b = 4;
            c = 3;
            d = (a + b) / c;
            Console.WriteLine(d);
        }

        static void IntPrecisionAndLimits()
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");
            //
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
            //
            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Integer Math:");
            IntegerMath();
            Console.WriteLine("Order Of Operands:");
            OrderOfOperands();
            Console.WriteLine("Integer Precision And Limits");
            IntPrecisionAndLimits();
        }
    }
}
