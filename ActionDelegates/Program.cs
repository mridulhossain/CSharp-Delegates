using System;

namespace ActionDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Action delegates like func delegates but Action delegates can't return anything it's has void return method */

            Action<int, int> Calculator = Add;
            Calculator += Sub;
            Calculator += Mul;
            Calculator(10,5);

            // lambda anonymous action delegates method.
            Action<String, String> Grettings = (String name, string grettings) => Console.WriteLine($"{grettings},{name}");
            Grettings("Mridul", "Good Bye");

        }


        public static void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }


        public static void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }


        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }

    }
}
