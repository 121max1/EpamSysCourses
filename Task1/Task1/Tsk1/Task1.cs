using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Task1FirstPart
{
    enum FontStyle
    {
        Bold,
        Italic,
        Underline,
        None
    }
    public static class Task1_1
    {

        public static int SquareRectangle(int a, int b)
        {
            if (a > 0 && b > 0)
            {
                return a * b;
            }
            else
            {
                throw new Exception("Invalid input. Values must be greater than zero");
            }
        }
        public static void Triangle(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        public static void AnotherTriangle(int n)
        {
            int stars = 1;
            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < stars; k++)
                {
                    Console.Write("*");
                }
                stars += 2;
                Console.WriteLine();
            }
        }

        public static void XMasTree(int n)
        {
            for (int triangleNum = 0; triangleNum <= n; triangleNum++)
            {
                int stars = 1;
                for (int i = triangleNum; i > 0; i--)
                {
                    for (int j = 0; j < i + n - triangleNum; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < stars; k++)
                    {
                        Console.Write("*");
                    }
                    stars += 2;
                    Console.WriteLine();
                }
            }
        }
        public static int SumOfNumbers()
        {
            int sum = 0;
            for (int num = 1; num < 1001; num++)
            {
                if (num % 3 == 0 || num % 5 == 0)
                {
                    sum += num;
                }
            }
            return sum;

        }
        private static void GetState(FontStyle[] styles)
        {
            if (styles.Length == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var style in styles)
                {
                    Console.Write(style.ToString() + " ");
                }
                Console.WriteLine();
            }

        }
        public static void FontAdjustment()
        {
            List<FontStyle> styles = new List<FontStyle>();
            Console.Write("Параметры надписи: ");
            GetState(styles.ToArray());
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(@"Введите:
    1: bold
    2: italic
    3: underline");
                int choice = int.Parse(Console.ReadLine());
                FontStyle styleToSet = FontStyle.Bold;
                switch (choice)
                {
                    case 1:
                        styleToSet = FontStyle.Bold;
                        break;
                    case 2:
                        styleToSet = FontStyle.Italic;
                        break;
                    case 3:
                        styleToSet = FontStyle.Underline;
                        break;
                }
                if (styles.Contains(styleToSet))
                {
                    styles.Remove(styleToSet);
                }
                else
                {
                    styles.Add(styleToSet);
                }
                GetState(styles.ToArray());
            }
        }

        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        static int[] InsertionSort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }

                array[j] = key;
            }

            return array;
        }
        public static void ArrayProcessing()
        {
            int[] array = new int[10];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            int max = array[0];
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Максимум: {0}", max);
            Console.WriteLine("Минимум: {0}", min);
            int[] sortedArray = InsertionSort(array);
            Console.WriteLine("Отсортированный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        static public void NoPositive()
        {
            int[,,] arr = new int[3, 3, 3];
            var random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = random.Next(-100, 101);
                        Console.Write(arr[i, j, k] + " ");
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        if (arr[i, j, k] > 0)
                        {
                            arr[i, j, k] = 0;
                        }
                        Console.Write(arr[i, j, k] + " ");
                    }
                }
            }
        }

        static public void NonNegativeSum()
        {
            int[] arr = new int[10];
            var random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-10, 10);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int sum = 0;
            foreach (var num in arr)
            {
                if (num >= 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine("Сумма неотрицательных: {0} ", sum);
        }

        static public void TwoDArray()
        {
            int[,] arr = new int[3, 3];
            var random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(-10, 10);
                    Console.Write(arr[i, j] + " ");

                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += arr[i, j];
                    }

                }
            }
            Console.WriteLine("Сумма на четных позициях: {0} ", sum);
        }
    }
}
