using System;
using System.Collections.Generic;

public class GenericStack<T>
{
    private Stack<T> stack = new Stack<T>();

    public void Push(T t)
    {
        stack.Push(t);
    }

    public T Pop()
    {
        return stack.Pop();
    }

    public static void Main(string[] args)
    {
        GenericStack<object> stack = new GenericStack<object>();

        stack.Push(2);
        stack.Push(2.2);
        stack.Push("String");

        Console.WriteLine((string)stack.Pop());
        Console.WriteLine((double)stack.Pop());
        Console.WriteLine((int)stack.Pop());
    }
}
