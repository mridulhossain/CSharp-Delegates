using System;
using System.Collections.Generic;

namespace PredicateDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            /* predicate delegates get one input and return boolean and you can write also lamda method in this */

            List<string> names = new List<string>() { "Mridul","Babu","Bijoy","Mubasher","Upama","Mehdi" };
            Predicate<string> Check = IsExist;

            var result = names.FindAll(Check); //here FindAll method want's a predicate delegates

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            /* lamda method */
            Predicate<string> NameCheck = (string name) => name.StartsWith('U');
            var filteredNames = names.FindAll(NameCheck);
            foreach (var item in filteredNames)
            {
                Console.WriteLine(item);
            }

        }

        public static bool IsExist(string name) {
            if (name.StartsWith('M'))
            {
                return true;
            }

            return false;
        }
    }
}
