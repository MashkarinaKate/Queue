using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Машкарины_Екатерины
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(3);
            q.Enqueue(10);
            for(int i = 0; i < q.size; i++)
            {
                Console.Write(q.array[i] + " ");
            }
            Console.WriteLine("\n"+ q.Peek());
            q.Enqueue(5);
            for (int i = 0; i < q.size; i++)
            {
                Console.Write(q.array[i] + " ");
            }
            Console.WriteLine();
            q.Dequeue();
            for (int i = 0; i < q.size; i++)
            {
                Console.Write(q.array[i] + " ");
            }
            q.Clear();
            Console.WriteLine("/");
            Console.WriteLine(q.Dequeue());
            for (int i = 0; i < q.size; i++)
            {
                Console.Write(q.array[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
