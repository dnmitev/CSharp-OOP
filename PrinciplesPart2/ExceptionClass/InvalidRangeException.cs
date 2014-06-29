namespace ExceptionClass
{
    using System;
    using System.Linq;

    public class InvalidRangeException<T> : ApplicationException
    {
        public InvalidRangeException(string message, T start, T end, Exception ex) : base(message, ex)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string message, T start, T end) : this(message, start, end, null)
        {
        }

        public InvalidRangeException(T start, T end) : this(null, start, end, null)
        {
        }

        public T End { get; set; }
        
        public T Start { get; set; }
    }
}