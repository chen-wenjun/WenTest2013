using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CircularArray<T>
    {
        private T[] array;
        private int startingIndex;
        public CircularArray(T[] items)
        {
            array = new T[items.Length];
            for (int i = 0; i < items.Length; i++)
                array[i] = items[i];

            startingIndex = 0;
        }

        public void Rotate(int moves)
        {
            startingIndex = GetIndex(startingIndex, -moves);
        }

        public IEnumerable<T> GetElements()
        {
            int index = startingIndex;
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[index];
                index = GetIndex(index, 1);
            }
        }

        public T this[int index]
        {
            get 
            {
                return array[GetIndex(startingIndex, index)];
            }
            set 
            {
                array[GetIndex(startingIndex, index)] = value;
            }
        }

        private int GetIndex(int currentIndex, int moves)
        {
            return (currentIndex + (moves % array.Length) + array.Length) % array.Length;
        }

        public void Print()
        {
            foreach (T element in GetElements())
            {
                Console.Write(element.ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}
