using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ClinkIT
{
    public class WordFinder2 : FinderMaster, IFinderRepository
    {
        public WordFinder2(IEnumerable<string> dictionary) { this.dictionary = dictionary; }
        public IList<string> Find(String[] src)
        {
            int srcLength = src.Length;
            this.src = src;
            string srcConvertToString = string.Join("", src);

            foreach (var dict in dictionary)
            {
                char[] dictChar = dict.ToCharArray();
                int lastIndex = 0;
                int firstIndex = 0;
                String words = "";

                foreach (var resp in dictChar)
                {
                    bool nearIndex = true;

                    if (lastIndex != 0 || firstIndex != 0)
                    {
                        nearIndex = this.validateRowIndex(resp, firstIndex, lastIndex);
                    }

                    lastIndex = src.ToList().FindLastIndex(c => c.Contains(resp));
                    firstIndex = src.ToList().FindIndex(c => c.Contains(resp));

                    if (nearIndex)
                        words += resp;
                }

                if (words == dict)
                {
                    this.addAnswers(words);
                }
            }
            return answerList;
        }

        private bool validateRowIndex(char resp, int firstIndex, int lastIndex)
        {
            int newLastIndex = this.src.ToList().FindLastIndex(c => c.Contains(resp));
            int newFirstIndex = this.src.ToList().FindIndex(c => c.Contains(resp));

            int a = newFirstIndex - firstIndex;
            int b = lastIndex - newLastIndex;

            if (a == 0 || a == 1)
            {
                return true;
            }

            if (b.ToString().Replace("-", "") == "0" || b.ToString().Replace("-", "") == "1")
            {
                return true;
            }

            if (a.ToString() == "-2" && b.ToString() == "-2")
            {
                return true;
            }
            return false;
        }
        private void addAnswers(String name)
        {
            if (!answerList.Any(x => x == name))
            {
                answerList.Add(name);
            }
        }
    }
}