using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Assignment4_Class
    {
        private int[] stack = new int[5];
        private int top = -1;

        public void Push(int value)
        {
            Console.WriteLine("Push");
            top++;
            stack[top] = value;
        }

        public int Pop()
        {
            Console.WriteLine("Pop");
            int value = stack[top];
            top--;
            return value;
        }

        public int Peek()
        {
            Console.WriteLine("Peek");
            return stack[top];
        }

        public void Display()
        {
            Console.WriteLine();
            foreach (var i in stack)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Assignment4_Class assignment = new Assignment4_Class();
            assignment.Push(10);
            assignment.Push(20);
            assignment.Push(30);
            assignment.Push(40);
            assignment.Push(50);
            assignment.Display();
            int value = assignment.Pop();
            Console.WriteLine(value);
            value = assignment.Peek();
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
/*
Perform Stack Operations 

 */
