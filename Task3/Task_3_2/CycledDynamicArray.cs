using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_2
{
    public class CycledArrayEnumerator<T> : IEnumerator<T>
    {
        CycledDynamicArray<T> array;
        int position = -1;
        public CycledArrayEnumerator(CycledDynamicArray<T> array)
        {
            this.array = array;
        }
        public T Current
        {
            get
            {
                return array[position];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return array[position];
            }
        }

        public void Dispose()
        {
            // Nothing to Dispose there
        }

        public bool MoveNext()
        {
            if(position == array.Length-1)
            {
                position = 0;
                return true;
            }
            else
            {
                position++;
                return true;
            }
        }

        public void Reset()
        {
            position = 0;
        }
    }
    public class CycledDynamicArray<T> :DynamicArray<T>, IEnumerable<T>
    {
        
        public CycledDynamicArray():base()
        {

        }

        public CycledDynamicArray(IEnumerable<T> collection):base(collection)
        {
            
        }

        public CycledDynamicArray(int capacity):base(capacity)
        {

        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {

            return new CycledArrayEnumerator<T>(this);

        }
    }
}
