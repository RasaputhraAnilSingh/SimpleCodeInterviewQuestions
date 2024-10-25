using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    public class Queue1 : Stack1
    {
        public override void process(int a)
        {
            Queue<string> q = new Queue<string>();
            string[] m = { "a", "b", "c", "d" };
            for (int i = 0; i < a; i++)
            {
                q.Enqueue(m[i]);
            }
            Console.WriteLine("q is printing below");
            foreach (string i in q)
            {
                Console.WriteLine(i);
            }
            //int pop = q.Dequeue();
            //Console.WriteLine("Pop is printing below");
            //Console.WriteLine(pop);
            //Console.WriteLine("q is printing after pop below");
            //foreach (int i in q)
            //{
            //    Console.WriteLine(i);
            //}
            Console.ReadLine();
        }
    }
}
