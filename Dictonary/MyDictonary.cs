using System;
using System.Collections.Generic;
using System.Text;

namespace Dictonary
{
    class MyDictonary<T>
    {
        T[] items;
        T[] temp;
        public MyDictonary()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            temp = items;
            items = new T[items.Length + 1];

            for (int i = 0; i < temp.Length; i++)
            {
                items[i] = temp[i];
            }
            items[items.Length - 1] = item;
        }
        public void Listele()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine((i+1)+". Word:"+items[i]);
            }
        }
       
    }
}
