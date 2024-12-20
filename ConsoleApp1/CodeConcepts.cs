﻿using System;
using System.Linq;


namespace ConsoleApp1
{
    public class CodeConcepts
    {
       
        /// <summary>
        /// Two Dimensional Array
        /// </summary>
        public void twoDimenalArray()
        {
           
            int[,] array = new int[2, 3]
            {
                { 1,2,3},{ 5,6,7}
            };
            //looping to array
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Reverse string
        /// </summary>
        public void reverseString()
        {
            string name = "AnilSingh";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }
        }
        /// <summary>
        /// Remove duplicates in Array
        /// </summary>
        public void removeDuplicateValuesFromArray()
        {
            int[] array = { 1, 2, 2, 3, 4, 4, 5, 6, 6, 7 };
            int[] array1 = new int[array.Length];
            int uniq = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < uniq; j++)
                {
                    if (array[i] == array1[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    array1[uniq] = array[i];
                    uniq++;
                }
            }

            int[] array3 = new int[uniq];
            for (int i = 0; i < uniq; i++)
            {
                array3[i] = array1[i];
                Console.Write(array3[i]);

            }

        }
        /// <summary>
        /// find the second highest value in Array
        /// </summary>
        /// <param name="distinctArray">distinct Array</param>
        /// <returns></returns>
        private int findSecondHighestValue(int[] distinctArray)
        {
            int secondHighestValue = distinctArray[distinctArray.Length - 2];
            return secondHighestValue;
        }
        /// <summary>
        /// find the highesr value in Array
        /// </summary>
        public void findHighestValueInArray()
        {
            int[] array = { 28, 23, 2, 2, 232, 23, 32, 2 };
            var array2 = array.Distinct().OrderBy(x => x).ToArray();
            Console.WriteLine("highestValueinarray is :" + array2[array2.Length - 1]);
            int secondHighest = findSecondHighestValue(array2);
            Console.WriteLine("secondhighestValueinarray is :" + secondHighest);
        }
        /// <summary>
        /// process the fibonacciSeries
        /// </summary>
        public void fibonacciSeries()
        {
            int first = 0;
            int second = 1;
            int third;

            for (int i = 0; i < 10; i++)
            {
                Console.Write(first + " ");
                third = first + second;
                first = second;
                second = third;
            }
            Console.WriteLine();
        }
       /// <summary>
       /// string is a palindromic
       /// </summary>
       /// <returns></returns>
        public bool IsStringPalindrome()
        {
            string word = string.Empty;
            Console.WriteLine("Enter a word to check is palindrome or not : ");
            word = Console.ReadLine();
            
            int left = 0;
            int right = word.Length - 1;

            while (left < right)
            {         
                if (char.ToLower(word[left]) != char.ToLower(word[right]))
                {
                    return false; 
                }
                left++;
                right--;
            }
            return true;
        }
        /// <summary>
        /// To find the count of Vowels in a word.
        /// </summary>
        public void findCountOfVowelsInString()
        {
            Console.WriteLine("Enter a Name : ");
            string name = Console.ReadLine();
            int count = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            for (int x = 0;x < name.Length;x++)
            {
                for (int y = 0;y < vowels.Length; y++)
                {
                    if (name[x] == vowels[y] )
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count) ;
        }
        /// <summary>
        /// check two string are same are not using loop
        /// </summary>
        public void givenTwoStringIsEqual()
        {
            Console.WriteLine("Enter first word : ");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter second word : ");
            string word2 = Console.ReadLine();
            if (word1.Length == word2.Length)
            {
                string word3 = String.Empty;
                for (int x = 0; x < word1.Length; x++)
                {
                    for (int y = 0; y < word2.Length; y++)
                    {
                        if (word1[x] == word2[y])
                        {
                            word3 += word1[x];
                        }
                    }
                }
                if (word1 == word3)
                {
                    Console.WriteLine("Two words are same");
                }
               
            }
            else
            {
                Console.WriteLine("Two words are not same");
            }
           

        }
        /// <summary>
        /// 
        /// </summary>
        public void nonRepeatingLettersInString() 
        {
            Console.WriteLine("Enter a word : ");
            string word1 = Console.ReadLine();
            int count = 0;
            string[] uniqLetters = new string[word1.Length];

            for (int x = 0; x < word1.Length; x++)//anill
            {
                bool isUniq = false;
                for(int y = 0; y < count; y++)
                {
                    if (word1[x].ToString() == uniqLetters[y])
                    {
                        isUniq = true;
                        break;
                    }
                   
                }
                if (isUniq == false)
                {
                    uniqLetters[count] = word1[x].ToString();
                    count++;
                }
            }
            string[] isUniqletters = new string[count];
            for (int x = 0; x < isUniqletters.Length; x++) 
            {
                isUniqletters[x] = uniqLetters[x];
            }
            for (int y = 0; y < count; y++) 
            {
                Console.Write(isUniqletters[y]);
            }
        }
        /// <summary>
        /// This method used to get count of Repitative letters in string 
        /// </summary>
        public void countOfRepitativeLetters()
        {
            Console.WriteLine("Enter a word : ");
            string word1 = Console.ReadLine();
            string[] strings = new string[word1.Length];

            for (int x = 0; x < word1.Length; x++) 
            {
                int count = 0;
                for (int y = 0; y < word1.Length; y++) 
                {
                    if (word1[x] == word1[y])
                    {
                        count++;
                        strings[x] = word1[x].ToString() + count.ToString();
                    }
                }
            }
            strings = strings.Distinct().ToArray();
            for (int x = 0; x < strings.Length; x++) 
            { 
                Console.WriteLine(strings[x]);  
            }
        }


        public void Operation(ref int a, ref int b)
        {
            int g = a + b;
        }
        public void Operation1(out int a, out int b)
        {
            a = 10;
            b = 10;
        }
        public void BubbleSort()
        {
            
            
           int[] array = { 5, 2, 42, 3, 2, 8, 9 };
           for(int x = 0; x < array.Length; x++)
            {
                for (int y = 0; y < array.Length - 1 - x; y++)
                {
                    if (array[y] < array[y + 1])
                    {
                        int temp  = array[y + 1];
                        array[y + 1] = array[y];
                        array[y] = temp;
                    }
                }    

            }
            Console.Write(String.Join(",", array));
        }
    }
    
}



