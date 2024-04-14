using System;

namespace hello
{
    class StringRev
    {
        char[] charArray;
        private int front, end, maxsize;

        public StringRev(int size)
        {
            front = 0;
            maxsize = size;
            end = -1;
            charArray = new char[maxsize];
        }

        static void Main()
        {
            string input = Console.ReadLine();
            StringRev sr = new StringRev(input.Length);

            foreach (char c in input)
            {
                sr.push(c);
            }

            for (int i = 0; i < input.Length; i++)
            {
                char sc = sr.pop();
                Console.Write(sc);
            }
        }

        public void push(char c)
        {
            if (end == maxsize - 1)
            {
                Console.WriteLine("Queue is full");
                return;
            }
            else
            {
                charArray[++end] = c;
            }
        }

        public bool IsEmpty()
        {
            return front > end;
        }

        public char pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return '\0'; 
            }
            else
            {
                return charArray[end--];
            }
        }
    }
}
