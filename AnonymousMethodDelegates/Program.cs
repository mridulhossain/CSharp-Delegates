using System;

namespace AnonymousMethodDelegates
{
    class Program
    {
        // delegate declare
        public delegate int CalculatorHandler(int firstNumber, int secondNumber);


        static void Main(string[] args)
        {
            // anonymouse syntex
            CalculatorHandler calculatorHandler  = delegate (int firstNumber, int secoundNumber){ return firstNumber + secoundNumber; }; // you can decleare like this and here exist another method in down bellow
            CalculatorHandler calculatorHandler1 = (int firstNumber, int secoundNumber) => firstNumber + secoundNumber;

            InvokeDelegates(calculatorHandler, 50, 20);
            InvokeDelegates(calculatorHandler, 50, 30);

        }


        /// <summary>
        /// pass method as a perametter delegates
        /// </summary>
        /// <param name="calculatorHandler">here pass a method like this delegates signiture.</param>
        public static void InvokeDelegates(CalculatorHandler calculatorHandler, int firstNumber, int secoundNumber)
        {
            var result = calculatorHandler.Invoke(firstNumber, secoundNumber);
            Console.WriteLine(result);
        }
    }
}
