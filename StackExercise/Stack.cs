using System;
using System.Collections.Generic;

namespace StackExercise
{
    public class Stack
    {
        private readonly List<Object> _list;

        public Stack()
        {
            _list = new List<object>();
        }

        public void Push(Object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Object equals to null");

            this._list.Insert(0, obj);
        }

        public Object Pop()
        {
            if (this._list.Count == 0)
                throw new InvalidOperationException("List of object is empty");

            var item = this._list[0];
            this._list.Remove(item);

            return item;
        }

        public void Clear()
        {
            this._list.Clear();
        }
    }
}