using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ClinkIT
{
    class Program
    {

        public static void Main(String[] args)
        {
            String[] dictionary = { "cold", "snow", "chill", "winds" };
            String[] src = { "abcdc", "fgwio", "chill", "pqnsd", "uvdxy" };

            //another trick 1 for finder works
            WordFinder wordFinder = new WordFinder(dictionary);

            var results = wordFinder.Find(src);
            foreach (string name in results)
            {
                Console.WriteLine(name + " ---- result 1 ");
            }

            String[] dictionary2 = { "KING", "TEST", "ALOHA", "HELLO" };
            String[] src2 = { "IMWBGWDGLP", "FPJCCCTMHS", "KEVTEKZCOC", "JHELLOWOFY",
                              "VCKINGBBNR", "HCAKFDDRKV", "BPRVUBVXQX", "TESTGNMMLH","ONJBFQEFAJ","IEALOHABTA"};

            WordFinder wordFinder2 = new WordFinder(dictionary2);
            results = wordFinder2.Find(src2);
            foreach (string name in results)
            {
                Console.WriteLine(name + " ---- result 2 ");
            }

            // //another trick 2 for finder works
            // WordFinder2 wordFinder3 = new WordFinder2(dictionary2);
            // var results2 = wordFinder3.Find(src2);

            // foreach (string name in results2)
            // {
            //     Console.WriteLine(name + " ---- result 3 ");
            // }
        }
    }
}
