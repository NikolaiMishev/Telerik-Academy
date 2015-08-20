using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class GenericList<T>
        where T : IComparable
    {
        private T[] collection;

        private int count;

        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                this.count = value;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new ArgumentException("Non existent element. Index out of range!");
                }

                return this.collection[index];
            }
            set
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new ArgumentException("Nonexistent element. Index out of range!");
                }

                this.collection[index] = value;
            }
        }

        public GenericList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("List cannot have less than or equl to 0 capacity!");
            }

            this.collection = new T[capacity];
            this.Count = 0;
        }

        public T Max()
        {
            T max = this.collection[0];
            for (int i = 1; i < Count; i++)
            {
                if (max.CompareTo(this.collection[i]) <= 0)
                {
                    max = this.collection[i];
                }
            }

            return max;
        }

        public T Min()
        {
            T min = this.collection[0];
            for (int i = 1; i < Count; i++)
            {
                if (min.CompareTo(this.collection[i]) > 0)
                {
                    min = this.collection[i];
                }
            }

            return min;
        }

        public void AddElement(T element)
        {
            if (Count >= collection.Length)
            {
                T[] newCollection = new T[this.collection.Length * 2];
                for (int i = 0; i < this.Count; i++)
                {
                    newCollection[i] = this.collection[i];
                }

                this.collection = newCollection;
            }

            this.collection[Count] = element;
            Count++;
        }

        public T GetElement(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentException("Invalid GenericList index!!");
            }

            return collection[index];
        }

        public void RemoveElement(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentException("Invalid GenericList index for removing!!");
            }

            for (int i = index; i < this.collection.Length - 1; i++)
            {
                this.collection[i] = this.collection[i + 1];
            }

            this.Count--;
        }

        public void InsertElement(T element, int index)
        {
            if (Count >= this.collection.Length)
            {
                T[] newCollection = new T[this.collection.Length * 2];
                for (int i = 0; i < this.Count; i++)
                {
                    newCollection[i] = this.collection[i];
                }

                this.collection = newCollection;
            }

            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentException("Invalid GenericList index! Index was outside the bounds of the collection");
            }

            for (int i = this.Count; i >= index + 1; i--)
            {
                this.collection[i] = this.collection[i - 1];
            }

            this.collection[index] = element;
            this.Count++;
        }

        public void ClearList()
        {
            this.collection = new T[this.collection.Length];
            this.Count = 0;
        }

        public int FindElement(T element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((element.CompareTo(this.collection[i])) == 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public override string ToString()
        {
            //return String.Join(", ", this._collection);
            if (this.Count == 0)
            {
                return "Empty list";
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                sb.Append(String.Format("{0}, ", this.collection[i]));
            }

            return sb.ToString().TrimEnd(' ', ',');
        }
    }
}
