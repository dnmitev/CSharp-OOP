namespace Generics
{
    using System;
    using System.Text;

    public class GenericList<T> where T : IComparable
    {
        // fields
        private T[] list;
        private int currElement = 0; // try to implement it with a property!!!!

        // constructors
        public GenericList(int capacity)
        {
            this.list = new T[capacity];
        }

        // setting default capacity if it is not strictly given
        public GenericList()
            : this(4)
        {
        }

        public int CurrElement
        {
            get
            {
                return this.currElement;
            }

            set
            {
                this.currElement = value;
            }
        }

        // define an indexation to access elements by index
        public T this[int index]
        {
            get
            {
                return this.list[index];
            }

            set
            {
                if (index < 0 || index >= this.CurrElement)
                {
                    throw new IndexOutOfRangeException("Index is out of range!");
                }

                this.list[index] = value;
            }
        }

        // methods

        // adding elements to the list
        public void AddElement(T value)
        {
            if (this.CurrElement == this.list.Length)
            {
                this.DoubleTheCapacity();
            }

            this.list[this.CurrElement] = value;
            this.CurrElement++;
        }

        // removing elements by index
        public void RemoveElement(int index)
        {
            if (index < 0 || index >= this.CurrElement)
            {
                throw new IndexOutOfRangeException("The index is out of range");
            }
            else
            {
                T[] newArray = new T[this.list.Length];

                for (int i = 0; i < index; i++)
                {
                    newArray[i] = this.list[i];
                }

                for (int i = index + 1; i < this.CurrElement; i++)
                {
                    newArray[i - 1] = this.list[i];
                }

                this.list = newArray;
                this.CurrElement--;
            }
        }

        // inserting elements by index and value
        public void InsertElement(int index, T value)
        {
            if (index == this.list.Length)
            {
                this.DoubleTheCapacity();
            }

            if (index < 0 || index >= this.CurrElement)
            {
                throw new IndexOutOfRangeException("The index is out of range");
            }
            else
            {
                T[] newArray = new T[this.list.Length];

                for (int i = 0; i < index; i++)
                {
                    newArray[i] = this.list[i];
                }

                newArray[index] = value;

                for (int i = index + 1; i < this.CurrElement; i++)
                {
                    newArray[i] = this.list[i];
                }

                this.list = newArray;
                this.CurrElement++;
            }
        }

        // getting the count of elements in the list
        public int Count()
        {
            return this.CurrElement;
        }

        // clearing list data
        public void Clear()
        {
            this.list = new T[4];
            this.CurrElement = 0;
        }

        // finding elements by value
        public int FindElement(T value)
        {
            int index = -1;

            for (int i = 0; i < this.list.Length; i++)
            {
                if (value.Equals(this.list[i]))
                {
                    return i;
                }
            }

            return index;
        }

        // find min element in the list
        public T MinElement()
        {
            T min = this.list[0];

            for (int i = 1; i < this.list.Length; i++)
            {
                if ((dynamic)min > (dynamic)this.list[i])
                {
                    min = this.list[i];
                }
            }

            return min;
        }

        // find max element in the list
        public T MaxElement()
        {
            T max = this.list[0];

            for (int i = 1; i < this.list.Length; i++)
            {
                if ((dynamic)max < (dynamic)this.list[i])
                {
                    max = this.list[i];
                }
            }

            return max;
        }

        // overriding ToString() 
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.list.Length; i++)
            {
                result.Append(this.list[i] + "; ");
            }

            result.AppendLine();

            return result.ToString();
        }

        // double the list capacity
        private void DoubleTheCapacity()
        {
            T[] newArray = new T[this.list.Length * 2];

            for (int i = 0; i < this.list.Length; i++)
            {
                newArray[i] = this.list[i];
            }

            this.list = newArray;
        }
    }
}
