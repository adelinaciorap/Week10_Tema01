using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer123_Generics
{
    public class GenericList<T> where T : IComparable<T>
    {
        private const int fixedCapacity = 10;
        private T[] arr;
        private int index;

        public GenericList()
        {
            this.arr = new T[fixedCapacity];
            this.index = 0;
        }

        public T this[int index]
        {
            get { return this.arr[index]; }
            set { this.arr[index] = value; }
        }

        public void Add(T element)
        {
            if (this.index == this.arr.Length)
            {
                AutoGrow();
            }
            this.arr[this.index] = element;
            this.index++;
        }


        public void AutoGrow()
        {
            T[] newArr = new T[this.arr.Length * 2];
            for (int i = 0; i < this.arr.Length; i++)
            {
                newArr[i] = this.arr[i];
            }
            this.arr = newArr;
        }

        public void Insert(int index, T element)
        {
            if (this.index >= arr.Length)
            {
                AutoGrow();
            }

            if (index < this.arr.Length)
            {
                T[] newArr = new T[this.arr.Length];
                for (int i = 0; i < index; index++)
                {
                    newArr[i] = arr[i];
                }
                newArr[index] = element;

                for (int i = index - 1; i < newArr.Length; i++)
                {
                    newArr[i] = arr[i - 1];

                }
                arr = newArr;
            }
            else
            {
                throw new IndexOutOfRangeException("Index not in the range");
            }
        }

        public void RemoveElement(int index)
        {
            if (index < this.arr.Length)
            {
                T[] newArr = new T[this.arr.Length];
                for (int i = 0; i < index; i++)
                    newArr[i] = arr[i];


                for (int i = index + 1; i < newArr.Length; i++)
                {
                    newArr[i - 1] = arr[i];
                }
                arr = newArr;
            }
        }

        public int Indexof(T element)
        {
            for (int i = 0; i < this.index; i++)
            {
                if (this.arr[i].Equals(element))
                    return i;
            }

            return -1;
        }

        public void Clear()
        {
            arr = new T[fixedCapacity];
        }

        public override string ToString()
        {
            var printString = new StringBuilder();
            for (int i = 0; i < this.index; i++)
            {
                printString.Append(arr[i] + ",");
            }

            if (printString.Length > 0)
            {
                printString.Remove(printString.Length - 1, 1);
                return printString.ToString();
            }
            else
            {
                return null;
            }
        }

        public T Min()
        {
            if (this.index <= 0)
            {
                throw new ArgumentException("No elements in the list!");
            }
            T min = this.arr[0];

            for (int i = 0; i < this.index; i++)
            {
                if (this.arr[i].CompareTo(min) < 0)
                {
                    min = this.arr[i];
                }
            }
            return min;
        }

        public T Max()
        {
            if (this.index <= 0)
            {
                throw new ArgumentException("No elements in the list!");
            }
            T max = this.arr[0];

            for (int i = 0; i < this.index; i++)
            {
                if (this.arr[i].CompareTo(max) > 0)
                {
                    max = this.arr[i];
                }
            }
            return max;
        }
    }
}
