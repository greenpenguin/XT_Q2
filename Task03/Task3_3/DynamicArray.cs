using System;
using System.Collections;
using System.Collections.Generic;

namespace Task3_3
{
    public class DynamicArray<T> : IEnumerable<T>
    {
        private T[] dynamicArray;
        
        public int Length { get;  protected set; }
        
        public int Capacity => dynamicArray.Length;
        
        public DynamicArray(T[] dynamicArray)
        {
            this.dynamicArray = dynamicArray;
            Length = dynamicArray.Length;
        }

        public DynamicArray()
            :this(8)
        {}

        public DynamicArray(int n)
        {
            this.dynamicArray = new T[n];
            this.Length = n;
        }
        
        public DynamicArray(IEnumerable<T> n)
            :this(GetEnumerableLength(n))
        {
            var enumerator = n.GetEnumerator();
            enumerator.Reset();
            for (int i = 0; i < Length; i++)
            {
                enumerator.MoveNext();
                dynamicArray[i] = enumerator.Current;
            }
        }
        
        public static int GetEnumerableLength(IEnumerable<T> elems)
        {
            var enumerator = elems.GetEnumerator();
            enumerator.Reset();
            var enumerableLength = 0;
            while (enumerator.MoveNext())
            {
                enumerableLength++;
            }
            return enumerableLength;
        }
        
        public void Add(T elem)
        {
            while (this.Length > this.Capacity)
            {
                DoubleCapacity();
            }

            this.dynamicArray[this.Length++] = elem;
        }

        public void DoubleCapacity()
        {
            var temp = new T[this.Capacity * 2];
            this.dynamicArray.CopyTo(temp, 0);
            this.dynamicArray = temp;
        }
        
        public void AddRange(IEnumerable<T> elems)
        {

            var elemsLength = GetEnumerableLength(elems);
            while (elemsLength + this.Length > this.Capacity)
            {
                DoubleCapacity();
            }

            var elemsEnumerator = elems.GetEnumerator();
            elemsEnumerator.Reset();
            for (int i = 0; i < elemsLength; i++)
            {
                elemsEnumerator.MoveNext();
                dynamicArray[Length + i] = elemsEnumerator.Current;
            }

            Length += elemsLength;
        }
        
        public bool Remove(int index)
        {
            if (!IndexCheck(index))
            {
                return false;
            }
            for (var i = index; i < this.Length - 1; i++)
            {
                this.dynamicArray[i] = this.dynamicArray[i + 1];
            }

            Length--;
            return true;
        }
        
        private bool IndexCheck(int index)
        {
            return index < this.Length && index >= 0;
        }
        
        public bool Insert(T element, int index)
        {
            if (!IndexCheck(index))
            {
                throw new ArgumentOutOfRangeException();
            }

            var tmp = dynamicArray[Length - 1];
            for (var i = Length - 1; i > index; i--)
            {
                dynamicArray[i] = dynamicArray[i - 1];
            }
            dynamicArray[index] = element;
            Add(tmp);
            return true;
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            for (var i = 0; i < this.Length; i++)
            {
                yield return this.dynamicArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T this[int index]
        {
            get
            {
                if (!IndexCheck(index))
                {
                    throw new ArgumentOutOfRangeException();
                }

                return dynamicArray[index];
            }

            set
            {
                if (!IndexCheck(index))
                {
                    throw new ArgumentOutOfRangeException();
                }

                dynamicArray[index] = value;
            }
        }
        
    }
}