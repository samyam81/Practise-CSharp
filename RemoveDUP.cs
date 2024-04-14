using System;
using System.Collections.Generic;

namespace Kobbie
{
    class RemoveDuplicates
    {
        static void Main()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            int[] array = { 1, 1, 2, 3, 4, 5 };

            foreach (int value in array)
            {
                linkedList.AddLast(value);
            }

            LinkedList<int> result = RemoveDuplicatesFromSortedList(linkedList);

            Console.WriteLine("Linked List after removing duplicates:");
            foreach (int value in result)
            {
                Console.WriteLine(value);
            }
        }

        static LinkedList<int> RemoveDuplicatesFromSortedList(LinkedList<int> numbers)
        {
            LinkedList<int> result = new LinkedList<int>();

            if (numbers == null || numbers.Count == 0)
            {
                return result;
            }

            LinkedListNode<int> current = numbers.First;
            result.AddLast(current.Value);

            while (current.Next != null)
            {
                if (current.Value != current.Next.Value)
                {
                    result.AddLast(current.Next.Value);
                }
                current = current.Next;
            }

            return result;
        }
    }
}
