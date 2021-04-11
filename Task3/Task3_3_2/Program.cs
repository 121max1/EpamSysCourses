using System;

namespace Task3_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string str = Console.ReadLine();
            var type =  str.GetTextType();
            Console.WriteLine(type.ToString());
        }
    }
}
