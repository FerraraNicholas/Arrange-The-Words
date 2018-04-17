using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ArrangeTheWords
{
    class Program
    {

        static string arrange(string sentence)
        {
            string[] words = sentence.ToLower().Split(null);

            List<string> sentenceCollection = new List<string>();

            string res = null;

            int count = 0;

            foreach (string str in words)
            {
                if (str.Contains("."))
                {
                    var substring = str.Substring(0, str.Length - 1);
                    sentenceCollection.Add(substring);
                }
                else
                {
                    sentenceCollection.Add(str);
                }
            }

            sentenceCollection = sentenceCollection.OrderBy(x => x.Length).ToList();

            foreach (string word in sentenceCollection)
            {
                if (count == 0)
                {
                    var firstToUpper = word.Substring(0, 1).ToUpper() + word.Substring(1);
                    res = firstToUpper;

                } else if (count == sentenceCollection.Count - 1)
                {
                    res += " " + word + ".";
                }
                else
                {
                    res += " " + word;
                }

                count++;
            }

            return res;
        }

        static void Main(string[] args)
        {
            //string sentence = "The  lines are printed in reverse order.";
            //string sentence = "Here i come.";
            //string sentence = "I love to code.";
            string sentence = "This is very (old school)";
            arrange(sentence);
        }
    }
}
