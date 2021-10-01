using System;

namespace MulticastDelegates
{
    class Program
    {
        // delegates
        public delegate void Grettings(string name);
        static void Main(string[] args)
        {

            //multicast delegates syntex
            Grettings grettings = Hello;
            grettings += Welcome;
            grettings += GoodBye;
            grettings("Mridul");

            Console.WriteLine("-----------------------------------------------------------------------");

            // you can also write this syntex like this (multicast delegates)
            Grettings grettings1 = Hello;
            Grettings grettings2 = Welcome;
            Grettings grettings3 = GoodBye;

            Grettings processGrettings = grettings1 + grettings2 + grettings3;
            processGrettings("Rakib");

        }


        public static void Hello(string name)
        {
            Console.WriteLine("Hello! Mr."+name);
        }


        public static void Welcome( string name)
        {
            Console.WriteLine("Welcome Mr."+name);
        }

        public static void GoodBye(string name)
        {
            Console.WriteLine("Good Bye Mr."+name);
        }

    }
}
