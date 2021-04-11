using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task_3_2
{
    public class DynamicArray<T>: IEnumerable<T>, IEnumerable, ICloneable
    {
        enum ArrayExtendOptions
        {
            DoubleExtend,
            CollectionExtend
        }
        protected T[] array;
        private int _capacity;
        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                Length = _capacity;
                T[] newArray = new T[Capacity];
                Array.Copy(array, newArray, Length);
            }
        }
        public int Length { get; private set; }

        public DynamicArray()
        {
            _capacity = 8;
            array = new T[Capacity];
            Length = 0;
            
        }
        public T this[int index]
        {
            get
            {
                if (index>=0)
                {
                    return array[index];
                }
                else
                {
                    return array[Length+index];
                }    
                
            }
            set
            {
                if (index > 0)
                {
                    array[index] = value;
                }
                else
                {
                    array[Length + index] = value;
                }
            }
        }
        public DynamicArray(int capacity)
        {
            _capacity = capacity;
            array = new T[_capacity];
        }

        public DynamicArray(IEnumerable<T> collection)
        {
            _capacity = collection.Count();
            Length = Capacity;
            array = new T[_capacity];
            Array.Copy(collection.ToArray(), array, collection.Count());
        }
        private void ExtendArray(ArrayExtendOptions option, int length = 0)
        {
            if(option == ArrayExtendOptions.DoubleExtend)
            {
                _capacity *= 2;
            }
            else if(option == ArrayExtendOptions.CollectionExtend)
            {
                _capacity += length;
                
            }
            T[] newArray = new T[_capacity];
            Array.Copy(array, newArray, Length);
            array = newArray;
        }
        public void Add(T value)
        {
            if(Length == _capacity)
            {
                ExtendArray(ArrayExtendOptions.DoubleExtend);
            }
            array[Length] = value;
            Length++;

        }
        public void AddRange(IEnumerable<T> collectionToAdd)
        {
            if (_capacity < Length+collectionToAdd.Count())
            {
                ExtendArray(ArrayExtendOptions.CollectionExtend, collectionToAdd.Count());
            }
            Array.Copy(collectionToAdd.ToArray(), 0, array, Length, collectionToAdd.Count());
            Length += collectionToAdd.Count();
        }
        private static T[] Delete(T[] array, int indexToDelete)
        {
            var output = new T[array.Length - 1];
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i == indexToDelete) continue;
                output[counter] = array[i];
                counter++;
            }

            return output;
        }
        public bool Remove(T value)
        {
            int indexToRemove = -1;
            for(int i = 0; i < Length; i++)
            {
                if(array[i].Equals(value))
                {
                    indexToRemove = i;
                    break;
                }
            }
            if(indexToRemove == -1)
            {
                return false;
            }
            else
            {
                array = Delete(array, indexToRemove);
                Length--;
                return true;
            }
        }
        public bool Insert(T value, int position)
        {
            if(position>Length)
            {
                throw new ArgumentOutOfRangeException();
            }    
            if (Length == Capacity)
            {
                ExtendArray(ArrayExtendOptions.DoubleExtend);
            }
            Length++;
            for (int i = Length-1; i > position; i--)
            {
                array[i] = array[i-1];
                
            }
            array[position] = value;
            return true;
        }

       

        IEnumerator<T> GetEnumerator()
        {
            while(true)
            {

            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {

            for (int i = 0; i < Length; i++)
            {
                yield return array[i];
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public object Clone()
        {
            var copy = JsonConvert.SerializeObject(array);
            T[] newArray = JsonConvert.DeserializeObject<T[]>(copy);


            return new DynamicArray<T>()
            {
                _capacity = _capacity,
                Length = Length,
                array = newArray
            };

          }

        public T[] ToArray()
        {
            return array;
        }
        }

    }

