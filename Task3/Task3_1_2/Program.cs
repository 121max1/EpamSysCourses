using System;
using System.Collections.Generic;

namespace Task3_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст для анализа: ");
            char[] separators = new char[] { ' ', '.', '!', ';', '?', ',', '>', '<' };
            string[] allWords = Console.ReadLine().ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            SortedSet<string> uniquewords = new SortedSet<string>(allWords);
            Dictionary<string, int> wordsAmount = new Dictionary<string, int>();
            foreach(var word in uniquewords)
            {
                wordsAmount.Add(word, 0);
            }
            foreach(var word in allWords)
            {
                wordsAmount[word]++;
            }
            double mean = 0;
            foreach (var pair in wordsAmount)
            {
                Console.WriteLine("{0} {1}",pair.Key,pair.Value);
                mean += pair.Value;

            }
            mean = mean/2;
            bool isAlright = true;
            List<string> oftenWords = new();
            foreach (var pair in wordsAmount)
            {
                if (pair.Value > mean && pair.Key.Length >= 3)
                {
                    oftenWords.Add(pair.Key);
                    isAlright = false;
                }
            }
            Console.WriteLine("Результаты анализа текста: ");
            if(isAlright)
            {
                Console.WriteLine("Всё хорошо!");
            }
            else
            {
                Console.Write("Некоторые слова в тексте повтояются слишком часто: ");
                foreach(var word in oftenWords)
                {
                    Console.Write(word + " ");
                    
                }
            }
            
        }
    }
}
