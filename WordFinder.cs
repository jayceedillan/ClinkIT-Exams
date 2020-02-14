using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ClinkIT
{

    public class WordFinder : FinderMaster
    {
        public WordFinder(IEnumerable<string> dictionary) { this.dictionary = dictionary; }


        public IList<string> Find(String[] src)
        {
            int srcLength = src.Length;
            string srcConvertToString = string.Join("", src);

            StringBuilder sbSrc = new StringBuilder();
            for (int i = 0; i < srcLength; i++)
            {
                for (int a = 0; a < srcLength; a++)
                {
                    sbSrc.Append(src[a][i]);
                }

            }

            answerList = new List<string>();
            foreach (string name in dictionary)
            {
                //check horizontal
                if (src.Contains(name))
                    this.addAnswers(name);
                //check vertical
                if (sbSrc.ToString().Contains(name))
                    this.addAnswers(name);
            }
            return answerList;
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



