using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Машкарины_Екатерины
{
    public class Queue<T>
    {
        public T[] array;
        int head;
        int tail;
        public int size;
        int capacity;
        T f;
        public Queue()
        {
            size = 0;
            head = 0;
            tail = -1;
            array = new T[1];
            capacity = 1;
        }
        bool isEmpty()
        {
            if (size == 0) return true;
            else return false;
        }
        public void Enqueue(T item)
        {
            if (item == null)
            {
                throw new Exception();
            }
            tail++;
            size++;
            capacity++;
            T[] array2 = new T[capacity];
            Array.Copy(array, array2, tail);
            array2[tail] = item;
            array = new T[size];
            Array.Copy(array2, array, size);
        }
        public T Dequeue()
        {
            if (!isEmpty())
            {
                head++;
                size--;
                capacity--;
                return array[head];
            }
            else return f;
        }
        public T Peek()
        {
            if (!isEmpty())
                return array[tail];
            else return f;
        }
        public void Clear()
        {
            array = new T[1];
            head = 0;
            size = 0;
        }
        public int Count
        {
            get { return size; }
        }
    }
}

