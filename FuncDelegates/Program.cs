using System;

namespace FuncDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Func can get 16 parameter,and last data type is Func return type. when you use func delegates,your method should return a data*/

            Func<int, int, int> CalculatorHandler = Add;
            var result =   CalculatorHandler.Invoke(12,35);
            Console.WriteLine(result);


            // lambda  expression useing func anonymous
            Func<int, int, int> Mul = (int a, int b) => a * b;
            Mul.Invoke(10, 5);

        }


        public static int Add(int firstNumber,int secoundNumber)
        {
            return firstNumber + secoundNumber;
        }
    }
}
