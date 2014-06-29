namespace BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class BitArray64 : IEnumerable<int>
    {
        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public ulong Number { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < ConvertToBits().Length; i++)
            {
                if ((i+1) % 4 == 0)
                {
                    sb.AppendFormat("{0} ", ConvertToBits()[i]);
                }
                else
                {
                    sb.AppendFormat("{0}", ConvertToBits()[i]);
                }
            }

            return sb.ToString();
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Index of BitArray64 is out of range.");
                }

                int[] bits = this.ConvertToBits();

                return bits[index];
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            int[] bits = this.ConvertToBits();

            for (int i = 0; i < bits.Length; i++)
            {
                yield return bits[i];
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is BitArray64))
            {
                return false;
            }

            BitArray64 other = obj as BitArray64;

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Number == other.Number;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + this.Number.GetHashCode();
                return result;
            }
        }

        private int[] ConvertToBits()
        {
            // I am using bitwise to convert ulong to bits
            int[] bits = new int[64];

            for (int i = 0; i < bits.Length; i++)
            {
                int bit = (int)(this.Number >> i) & 1;

                bits[63 - i] = bit;
            }

            return bits;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !first.Equals(second);
        }
    }
}