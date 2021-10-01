using System;

namespace PassMethodAsAPerametterDelegates
{
    class Program
    {
        // delegate declare
        public delegate int CalculatorHandler(int firstNumber, int secondNumber);

        static void Main(string[] args)
        {
            CalculatorHandler calculatorHandler = Add;
            InvokeDelegates(calculatorHandler,10,25);
        }

        // <summary>
        /// add method
        /// </summary>
        /// <param name="a"> int type </param>
        /// <param name="b"> int type </param>
        /// <returns> a + b </returns>
        public static int Add(int a, int b)
        {
            return a + b;
        }


        /// <summary>
        /// pass method as a perametter delegates
        /// </summary>
        /// <param name="calculatorHandler">here pass a method like this delegates signiture.</param>
        public static void InvokeDelegates(CalculatorHandler calculatorHandler,int firstNumber, int secoundNumber)
        {
            var result = calculatorHandler.Invoke(firstNumber, secoundNumber);
            Console.WriteLine(result);
        }

    }
}
