using System;
using System.Collections.Generic;

public class MergeSort1
{
    public static void Main(string[] args)
    {
        int[] arr = {6, 3, 9, 5, 2, 8};
        int n = arr.Length;

        LinkedList<int> linkedList = new LinkedList<int>();
        foreach (int num in arr)
        {
            linkedList.AddLast(num);
        }

        Divide(linkedList, 0, n - 1);

        Console.WriteLine("Sorted Linked List:");
        foreach (int num in linkedList)
        {
            Console.Write(num + " ");
        }
    }

    private static void Divide(LinkedList<int> linkedList, int Si, int Ei)
    {
        if (Si < Ei)
        {
            int mid = Si + (Ei - Si) / 2;
            Divide(linkedList, Si, mid);
            Divide(linkedList, mid + 1, Ei);
            Conquer(linkedList, Si, mid, Ei);
        }
    }

    private static void Conquer(LinkedList<int> linkedList, int si, int mid, int ei)
    {
        LinkedList<int> merge = new LinkedList<int>();
        LinkedListNode<int> node1 = linkedList.First;
        LinkedListNode<int> node2 = linkedList.First;

        // Move node1 to the middle
        for (int i = 0; i < mid; i++)
        {
            node1 = node1.Next;
        }

        // Move node2 to the element after the middle
        for (int i = 0; i <= mid; i++)
        {
            node2 = node2.Next;
        }

        while (node1 != null && node2 != null)
        {
            if (node1.Value <= node2.Value)
            {
                merge.AddLast(node1.Value);
                node1 = node1.Next;
            }
            else
            {
                merge.AddLast(node2.Value);
                node2 = node2.Next;
            }
        }

        // Add remaining elements from node1
        while (node1 != null)
        {
            merge.AddLast(node1.Value);
            node1 = node1.Next;
        }

        // Add remaining elements from node2
        while (node2 != null)
        {
            merge.AddLast(node2.Value);
            node2 = node2.Next;
        }

        LinkedListNode<int> mergeNode = merge.First;
        LinkedListNode<int> listNode = linkedList.First;
        while (mergeNode != null)
        {
            listNode.Value = mergeNode.Value;
            mergeNode = mergeNode.Next;
            listNode = listNode.Next;
        }
    }
}
