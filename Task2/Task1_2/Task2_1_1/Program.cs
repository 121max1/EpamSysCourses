using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString str = new MyString(new char[] { 'H', 'e', 'l', 'l', 'o' });
            MyString str1 = new MyString("Hello");
            Console.WriteLine(str == str1);
            foreach(var sym in str1.GetUniqueSymbols())
            {
                Console.WriteLine(sym);
            }
            MyString str2 = str.Concat(str1);
            Console.WriteLine(str2);

        }
    }
}
