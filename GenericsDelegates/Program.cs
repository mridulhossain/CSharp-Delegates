using System;

namespace GenericsDelegates
{
    class Program
    {
        // declare delegates
        public delegate void Grettings<T>(T param);


        static void Main(string[] args)
        {
            /* here we see now generics delegates example*/
            /* here three types of delefates(type's of generics delegates)
             * 1/Func
             * 2/Action
             * 3/Predicate*/

            Grettings<string> grettings = Hello;
            grettings += Welcome;
            grettings += GoodBye;
            grettings.Invoke("Bijoy");

        }


        public static void Hello(string name)
        {
            Console.WriteLine("Hello! Mr." + name);
        }


        public static void Welcome(string name)
        {
            Console.WriteLine("Welcome Mr." + name);
        }

        public static void GoodBye(string name)
        {
            Console.WriteLine("Good Bye Mr." + name);
        }

    }
}
