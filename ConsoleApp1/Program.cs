using System;


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


            //concepts.twoDimenalArray();
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
            concepts.givenTwoStringIsEqual();
            Console.ReadLine();
        }
    }
}
