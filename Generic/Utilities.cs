using System;

namespace Generic
{
    public class Utilities<T> where T : IComparable
    {
        public T Compare(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}