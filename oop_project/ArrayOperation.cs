using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_project
{
    public static class ArrayOperation
    {
        public static void AddElement<T>(T[] array, T element)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = element;
        }

        public static void Clear<T>(T[] array)
        {
            array = new T[0];
        }

        public static void RemoveElement<T>(T[] array, int index)
        {
            T[] temp = new T[array.Length - 1];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = i < index ? array[i] : array[i + 1];
            }
            array = temp;
        }
    }
}
