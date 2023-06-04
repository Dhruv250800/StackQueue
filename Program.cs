﻿// See https://aka.ms/new-console-template for more information
using StackQueue;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        UC1_Stack1 stack = new UC1_Stack1();
        UC2_Stack2 stack1 = new UC2_Stack2();
        stack.Push(70);
        stack.Push(30);
        stack.Push(56);

        Console.WriteLine("Stack elements:");
        while (!stack1.IsEmpty())
        {
            Console.WriteLine(stack1.Peek());
            stack1.Pop();
        }
        Queue queue = new Queue();
        Queue1 queue1 = new Queue1();
        queue.Enqueue(56);
        queue.Enqueue(30);
        queue.Enqueue(70);

        Console.WriteLine("Queue elements:");
        while (!queue1.IsEmpty())
        {
            Console.WriteLine(queue1.Dequeue());
        }
    }
}
