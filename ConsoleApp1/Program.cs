﻿using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack1 animal = new Stack1();
            //Console.WriteLine("Enter a integer value :");
            //int a = Convert.ToInt32(Console.ReadLine());
            //animal.process(a);
            //animal.process(a);

            //single LinkedList implementation

            //int a = 0;
            //LinkedList1 linkedList1 = new LinkedList1(a);
            //linkedList1.insertValue(10);
            //linkedList1.insertValue(20);
            //Console.ReadLine();


            //CodeConcepts
            CodeConcepts concepts = new CodeConcepts();


            concepts.twoDimenalArray();
            //concepts.fibonacciSeries();
            //.concepts.reverseString();
            //concepts.removeDuplicateValuesFromArray();
            //concepts.findHighestValueInArray();
            /*bool isPalidrome = concepts.IsStringPalindrome();
            if (isPalidrome)
            {
                Console.WriteLine("Palindromic");
            }
            else
            {
                Console.WriteLine("Non-Palindromic");
            }
            */
            // concepts.findCountOfVowelsInString();
            //concepts.givenTwoStringIsEqual();
            //concepts.nonRepeatingLettersInString();
            //concepts.countOfRepitativeLetters();

            ////DesignPatternOfSingletone
            //var a = ImplementationOfSingleton.Intance(1);
            //var b = ImplementationOfSingleton.Intance(2);

            //asychronos
            //Asychro asychro = new Asychro();
            //int mul = asychro.Mul(10,11);
            //int sum = asychro.Sum(10,11);
            //int sub = asychro.Sub(10,11);
            //List<int> values = new List<int>();
            //values.Add(sum);
            //values.Add(sub);
            //values.Add(sum);
            //foreach (int value in values) {
            //    Console.WriteLine(value + " ");
            //}
            //List<int> values1 = new List<int>();

            //Task task1 = new Task(() => { 
                
            //    int suba = asychro.Sub(4, 5);
            //    values1.Add(suba);
            //});
            //Task task2 = new Task(() => { int suma = asychro.Sum(4, 5); values1.Add(suma);
            //});
            //Task task3 = new Task(() => { int mula = asychro.Mul(4, 5); values1.Add(mula);
            //});
            //task1.Start();
            //task2.Start();
            //task3.Start();
            //foreach (int value in values1)
            //{
            //    Console.WriteLine(value + " ");
            //}
            Console.ReadLine();
        }
    }
}
    