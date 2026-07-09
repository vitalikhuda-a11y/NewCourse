using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;


namespace z
{


    public class MyStack<T>
    {

        private List<T> items = new List<T>();

        public bool isEmpty
        {
            get {

               return items.Count == 0;
            }
        
        
        }


        public void Push(T item)
        {

            items.Add(item);

        }


        public T Pop()
        {

            int lastIndex = items.Count - 1;
            T lastItem = items[lastIndex];

            items.RemoveAt(lastIndex);

            return lastItem;
        }


        public T Peek() { 
        
        int lastIndex = items.Count - 1;

            return items[lastIndex];
        
        }

    }
}
