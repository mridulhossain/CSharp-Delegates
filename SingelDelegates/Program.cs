using System;

namespace SingelDelegates
{
    class Program
    {
        // delegate declare
        public delegate int  CalculatorHandler(int firstNumber, int secondNumber);

        static void Main(string[] args)
        {
            // single delegates can be use to invoke a single method

            /*---------flow---------------
             * declare a delegate
             * set a target method
             * invoke a delegate*/


            // set target method and invoke(first style)
            CalculatorHandler calculatorHandler = Add; //set tergate
            var result = calculatorHandler.Invoke(10, 25); // invoke


            // or (secound style)
            CalculatorHandler calculatorHandler2 = new CalculatorHandler(Add); // set target
            var result2 = calculatorHandler2.Invoke(30, 40); // invoke



            //result
            Console.WriteLine(result);
            Console.WriteLine(result2);

        }



        /// <summary>
        /// add method
        /// </summary>
        /// <param name="a"> int type </param>
        /// <param name="b"> int type </param>
        /// <returns> a + b </returns>
        public static int Add(int a, int b)
        {
            return a + b;
        }

    }
}
