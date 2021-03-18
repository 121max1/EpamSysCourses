using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsk2
{
    static public class Task2
    {
        public static double AverageLength(string str)
        {
            char[] separators = new char[] { ' ', ',', '.', ';', ':' };
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            foreach (var word in words)
            {
                sum += word.Length;
            }
            return sum / (double)words.Length;
        }
        public static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            Console.WriteLine(AverageLength(sentence));
        }

        public static int LowerCase(string str)
        {
            char[] separators = new char[] { ' ', ',', '.', ';', ':' };
            List<string> words = new List<string>(str.Split(separators, StringSplitOptions.RemoveEmptyEntries));
            int cntLow = words.Where(word => char.IsLower(word[0])).Count();
            return cntLow;
        }

        public static string Doubler(string str1, string str2)
        {
            var lettersInStr2 = new List<char>();
            foreach (var letter in str2)
            {
                if (!lettersInStr2.Contains(letter))
                {
                    lettersInStr2.Add(letter);
                }
            }
            for (int i = 0; i < str1.Length; i++)
            {
                if (lettersInStr2.Contains(str1[i]))
                {
                    str1 = str1.Insert(i, str1[i].ToString());
                    i++;
                }

            }
            return str1;
        }
    }
}
