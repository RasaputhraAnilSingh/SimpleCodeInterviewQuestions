using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Stack1
    {
        public virtual void process(int a)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < a; i++)
            {
                stack.Push(i);
            }
            Console.WriteLine("Stack is printing below");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            int pop = stack.Pop();
            Console.WriteLine("Pop is printing below");
            Console.WriteLine(pop);
            Console.WriteLine("Stack is printing after pop below");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
