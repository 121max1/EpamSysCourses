using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_3_1
{
    public static class NumeicArrayExtensions
    {
        #region IntArrayExtensions
        public static int GetSum(this int[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            return array.Aggregate((x, y) => x + y);
        }

        public static int GetMean(this int[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            if (array.Length == 0)
            {
                throw new Exception("Array length must be more than zero");
            }
            return (int)(array.GetSum() / array.Length);
        }

        public static int GetMostRepeated(this int[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            if (array.Length == 0)
            {
                throw new Exception("Array length must be more than zero");
            }
            return array.GroupBy(n => n).OrderByDescending(g => g.Count()).FirstOrDefault().Key;
        }

        public static void ChangeEach(this int[] array, Func<int, int> action)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = action(array[i]);
            }
        }
        #endregion

        #region ByteArrayExtensions
        public static int GetSum(this byte[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            return array.Sum(x => x);
        }

        public static byte GetMean(this byte[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            if (array.Length == 0)
            {
                throw new Exception("Array length must be more than zero");
            }
            return (byte)(array.GetSum() / array.Length);
        }

        public static byte GetMostRepeated(this byte[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            if (array.Length == 0)
            {
                throw new Exception("Array length must be more than zero");
            }
            return array.GroupBy(n => n).OrderByDescending(g => g.Count()).FirstOrDefault().Key;
        }

        public static void ChangeEach(this byte[] array, Func<byte, byte> action)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = action(array[i]);
            }
        }
        #endregion

        #region SByteArrayExtensions
        public static int GetSum(this sbyte[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            return array.Sum(x => x);
        }

        public static sbyte GetMean(this sbyte[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            if (array.Length == 0)
            {
                throw new Exception("Array length must be more than zero");
            }
            return (sbyte)(array.GetSum() / array.Length);
        }

        public static sbyte GetMostRepeated(this sbyte[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            if (array.Length == 0)
            {
                throw new Exception("Array length must be more than zero");
            }
            return array.GroupBy(n => n).OrderByDescending(g => g.Count()).FirstOrDefault().Key;
        }

        public static void ChangeEach(this sbyte[] array, Func<sbyte, sbyte> action)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = action(array[i]);
            }
        }
        #endregion

        #region UIntArrayExtensions
        public static uint GetSum(this uint[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            return (uint)array.Sum(x => x);
        }

        public static uint GetMean(this uint[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            if (array.Length == 0)
            {
                throw new Exception("Array length must be more than zero");
            }
            return (uint)(array.GetSum() / array.Length);
        }

        public static uint GetMostRepeated(this uint[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            if (array.Length == 0)
            {
                throw new Exception("Array length must be more than zero");
            }
            return array.GroupBy(n => n).OrderByDescending(g => g.Count()).FirstOrDefault().Key;
        }

        public static void ChangeEach(this uint[] array, Func<uint, uint> action)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = action(array[i]);
            }
        }


        #endregion

        #region ShortArrayExtensions
        public static int GetSum(this short[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            return array.Sum(x => x);
        }

        public static short GetMean(this short[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            if (array.Length == 0)
            {
                throw new Exception("Array length must be more than zero");
            }
            return (short)(array.GetSum() / array.Length);
        }

        public static short GetMostRepeated(this short[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            if (array.Length == 0)
            {
                throw new Exception("Array length must be more than zero");
            }
            return array.GroupBy(n => n).OrderByDescending(g => g.Count()).FirstOrDefault().Key;
        }

        public static void ChangeEach(this short[] array, Func<short, short> action)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = action(array[i]);
            }
        }


        #endregion

        #region UShortArrayExtensions
        public static int GetSum(this ushort[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            return array.Sum(x => x);
        }

        public static ushort GetMean(this ushort[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            if (array.Length == 0)
            {
                throw new Exception("Array length must be more than zero");
            }
            return (ushort)(array.GetSum() / (ushort)array.Length);
        }

        public static ushort GetMostRepeated(this ushort[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            if (array.Length == 0)
            {
                throw new Exception("Array length must be more than zero");
            }
            return array.GroupBy(n => n).OrderByDescending(g => g.Count()).FirstOrDefault().Key;
        }

        public static void ChangeEach(this ushort[] array, Func<ushort, ushort> action)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = action(array[i]);
            }
        }


        #endregion

        #region LongArrayExtensions
        public static long GetSum(this long[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            return array.Sum(x => x);
        }

        public static long GetMean(this long[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            if (array.Length == 0)
            {
                throw new Exception("Array length must be more than zero");
            }
            return (long)(array.GetSum() / array.Length);
        }

        public static long GetMostRepeated(this long[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            if (array.Length == 0)
            {
                throw new Exception("Array length must be more than zero");
            }
            return array.GroupBy(n => n).OrderByDescending(g => g.Count()).FirstOrDefault().Key;
        }

        public static void ChangeEach(this long[] array, Func<long, long> action)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = action(array[i]);
            }
        }
        #endregion

        #region ULongArrayExtensions
        public static ulong GetSum(this ulong[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            ulong sum = 0;
            foreach(var num in array)
            {
                sum += num;
            }

            return sum;
        }

        public static ulong GetMean(this ulong[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            if (array.Length == 0)
            {
                throw new Exception("Array length must be more than zero");
            }
            return (array.GetSum() / (ulong)array.Length);
        }

        public static ulong GetMostRepeated(this ulong[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            if (array.Length == 0)
            {
                throw new Exception("Array length must be more than zero");
            }
            return array.GroupBy(n => n).OrderByDescending(g => g.Count()).FirstOrDefault().Key;
        }

        public static void ChangeEach(this ulong[] array, Func<ulong, ulong> action)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = action(array[i]);
            }
        }


        #endregion

        #region DoubleArrayExtensions
        public static double GetSum(this double[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }

            double sum = 0;
            foreach(var num in array)
            {
                sum += num;
            }
            return sum;
        }

        public static double GetMean(this double[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            if (array.Length == 0)
            {
                throw new Exception("Array length must be more than zero");
            }
            return array.GetSum() / array.Length;
        }

        public static double GetMostRepeated(this double[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            if (array.Length == 0)
            {
                throw new Exception("Array length must be more than zero");
            }
            return array.GroupBy(n => n).OrderByDescending(g => g.Count()).FirstOrDefault().Key;
        }

        public static void ChangeEach(this double[] array, Func<double, double> action)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = action(array[i]);
            }
        }


        #endregion

        #region FloatArrayExtensions
        public static float GetSum(this float[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }

            float sum = 0;
            foreach (var num in array)
            {
                sum += num;
            }
            return sum;
        }

        public static float GetMean(this float[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            if (array.Length == 0)
            {
                throw new Exception("Array length must be more than zero");
            }
            return array.GetSum() / array.Length;
        }

        public static float GetMostRepeated(this float[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            if (array.Length == 0)
            {
                throw new Exception("Array length must be more than zero");
            }
            return array.GroupBy(n => n).OrderByDescending(g => g.Count()).FirstOrDefault().Key;
        }

        public static void ChangeEach(this float[] array, Func<float, float> action)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = action(array[i]);
            }
        }


        #endregion

        #region DecimalArrayExtensions
        public static decimal GetSum(this decimal[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }

            decimal sum = 0;
            foreach (var num in array)
            {
                sum += num;
            }
            return sum;
        }

        public static decimal GetMean(this decimal[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            if (array.Length == 0)
            {
                throw new Exception("Array length must be more than zero");
            }
            return array.GetSum() / array.Length;
        }

        public static decimal GetMostRepeated(this decimal[] array)
        {
            if (array == null)
            {
                throw new Exception("Array can't be null");
            }
            if (array.Length == 0)
            {
                throw new Exception("Array length must be more than zero");
            }
            return array.GroupBy(n => n).OrderByDescending(g => g.Count()).FirstOrDefault().Key;
        }

        public static void ChangeEach(this decimal[] array, Func<decimal, decimal> action)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = action(array[i]);
            }
        }


        #endregion
    }
}
