using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MyString
    {
        private char[] array = new char[0];

        public MyString(string str)
        {
            array = str.ToCharArray();
        }
        
        public int Length
        {
            get
            {
                return array.Length;
            }
        }
        
        public char this[int index]
        {
            get
            {

                return array[index];

            }
            set
            {

                array[index] = value;

            }
        }
        public MyString()
        {
            array = new char[255];
        }

        public MyString(char[] arr)
        {
            array = new char[arr.Length];
            arr.CopyTo(array, 0);
        }

        public static bool operator == (MyString str1, MyString str2)
        {
            if(str1.array.Length != str2.array.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        return false;
                    }
                }
                return true;
            }

        }
        public static bool operator !=(MyString str1, MyString str2)
        {
            if (str1.array.Length != str2.array.Length)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public MyString Concat(MyString str)
        {
            if (str.Length + Length>255)
            {
                throw new Exception("String length is too long. Max Length value is 255");
            }
            else
            {
                return new MyString(array.Concat(str.array).ToArray());
            }

        }
        public bool Contains(char c)
        {
            foreach (var symbol in array)
            {
                if (symbol == c)
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(char c)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == c)
                {
                    return i;
                }
            }
            return -1;
        }

        public char[] ToCharArray()
        {
            char[] copy = null;
            Array.Copy(array, copy, array.Length);
            return copy;
        }

        public char[] GetUniqueSymbols()
        {
            List<char> unique= new List<char>();
            for (int i = 0; i < Length; i++)
            {
                if(!unique.Contains(array[i]))
                {
                    unique.Add(array[i]);
                }
            }
            return unique.ToArray();
        }

        public override string ToString()
        {
            return new string(array);
        }
    }
}
