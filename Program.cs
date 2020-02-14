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
            String[] dictionary = { "cold", "snow", "chill" };
            String[] src = { "abcdc", "fgwio", "chill", "pqnsd", "uvdxy" };

            //another trick 1 for finder works
            WordFinder wordFinder = new WordFinder(dictionary);

            var results = wordFinder.Find(src);
            foreach (string name in results)
            {
                Console.WriteLine(name);
            }
            //another trick 2 for finder works
            WordFinder2 wordFinder2 = new WordFinder2(dictionary);
            var results2 = wordFinder2.Find(src);

            foreach (string name in results2)
            {
                Console.WriteLine(name);
            }
        }
    }
}
