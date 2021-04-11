using System;
using System.Collections.Generic;

namespace Task3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Введите N: ");
            }
            while (!int.TryParse(Console.ReadLine(), out n));
            int eachNum;
            do
            {
                Console.Write("Введите, какой по счету человек будет вычеркнут каждый раунд: ");
            }
            while (!int.TryParse(Console.ReadLine(), out eachNum));
            List<int> people = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                people.Add(i);
            }
            bool isTheEnd = false;
            int roundCnt = 1;
            while (!isTheEnd)
            {
                try
                {
                    people.RemoveAt(eachNum-1);
                }
                catch
                {
                    Console.WriteLine("Игра окончена. Невозможно вычеркнуть больше людей.");
                    return;
                }
                Console.WriteLine("Раунд {0}. Вычеркнут человек. Людей осталось {1}", roundCnt,people.Count);
                roundCnt++;
            }
        }
    }
}
