using System;
using System.Threading;

namespace Task_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> dynamicArray = new DynamicArray<int>(new int[9] {1,2,3,4,5,6,7,8,9});
            foreach(var elem in dynamicArray)
            {
                Console.Write(elem +" ");
            }
            dynamicArray.Add(213);
            foreach (var elem in dynamicArray)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
            dynamicArray.AddRange(new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            foreach (var elem in dynamicArray)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
            dynamicArray.Add(1337);
    
            dynamicArray.Insert(228, 3);
            foreach (var elem in dynamicArray)
            {
                Console.Write(elem + " ");
            }
            dynamicArray[2] = 2281337;
            Console.WriteLine(dynamicArray[2]);
            foreach (var elem in dynamicArray)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
            CycledDynamicArray<int> arr = new CycledDynamicArray<int>();
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            foreach (var elem in arr)
            {
                Console.WriteLine(elem);
                Thread.Sleep(500);
                
            }
        }
    }
}