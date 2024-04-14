using System;

namespace hello
{
    class Queue
    {
        private int[] array;
        private int front, end, maxsize;

        public Queue(int size)
        {
            front = 0;
            maxsize = size;
            end = -1;
            array = new int[maxsize];
        }

        static void Main()
        {
            Queue queue = new Queue(10);

            for (int i = 0; i < 10; i++)
            {
                queue.push(i);
            }
            Console.WriteLine("Inserted Successfully");

            for (int i = 0; i < 10; i++)
            {
                int a = queue.pop();
                Console.WriteLine(a);
            }
        }

        public void push(int i)
        {
            if (end == maxsize - 1)
            {
                Console.WriteLine("Queue is full");
                return;
            }
            else
            {
                array[++end] = i;
            }
        }

        public bool IsEmpty()
        {
            return front > end;
        }

        public int pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                return array[front++];
            }
        }
    }
}
