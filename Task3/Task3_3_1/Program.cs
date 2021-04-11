using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3_3_1
{
    class Program
    {
      
        static void Main(string[] args)
        {

            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            arr.ChangeEach((x) => x * x);
            foreach(var num in arr)
            {
                Console.WriteLine(num);
            }    
        }
    }
}
