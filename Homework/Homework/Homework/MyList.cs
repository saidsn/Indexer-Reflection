using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class MyList<T>
    {
        private T[] array;

        public MyList()
        {
            array = new T[0];
        }

        public void Add(T data)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = data;
        }
        public void Clear(T data)
        {

        }

        public void Find(T data)
        {
            var result = data;
            foreach (var item in array)
            {
                Console.WriteLine(item);
                break;
            }
        }

        

        public void GetAllData()
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }


    }
}
