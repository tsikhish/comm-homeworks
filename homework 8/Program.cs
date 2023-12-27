using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;

namespace homework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());  
            int n = int.Parse(Console.ReadLine());
            task1(a, b, n);*/

            /*int n = int.Parse(Console.ReadLine());
            task2(n);*/
            /*string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();
            task3(firstWord, secondWord);*/
            /*List<string> words = new List<string>() { "mariam", "tsikhishvili" };
            List<int> numbers = new List<int>() { 1,2,3,4 };
            List<bool> trueFalse = new List<bool>() { true,true,false,false,false};
            task4(word);*/
            task5(1234);
            //task6
            /*int[] arr = { 1, 2, 3, 4 };
            int x = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        x++;
                        break;
                    }
                }
            }
            if (x > 0)
            {
                Console.WriteLine("yes");
            }

            else { Console.WriteLine("no"); }
            }
            */


        
        static void task5(int n)
        {
            string result = "";
            int x = 0;
            if (n / 10 == 0)
            {
                Console.WriteLine($"{n%10}");
            }
            else
            {
                task5(n / 10);
                Console.WriteLine($"-{n%10}");
            }
        }
        static void task4<T>(List<T> input) {  
            if(typeof(T) == typeof(string))
            {
                foreach(var item in input)
                {
                    Console.WriteLine(item.ToString().ToUpper());
                }
            }
            else if(typeof(T) == typeof(int))
            {
                int sum = 0;
                foreach(var item in input)
                {
                    sum += Convert.ToInt32(item);
                }
            }
            else if(typeof(T) == typeof(bool))
            {
                Console.WriteLine($"{input[0]},{input[input.Count - 1]},{input[input.Count/2]}");
            }
             }
        static void task3(string firstWord, string secondWord)
        {
            string result = "";
            if (firstWord.Length >= secondWord.Length)
            {
                for (int i = 0; i < secondWord.Length; i++)
                {
                    if (secondWord[secondWord.Length - 1 - i] == firstWord[firstWord.Length - 1 - i])
                    {
                        result = result + firstWord[firstWord.Length - 1 - i];
                    }
                }

            }
            else
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    if (secondWord[secondWord.Length - 1 - i] == firstWord[firstWord.Length - 1 - i])
                    {
                        result = result + firstWord[firstWord.Length - 1 - i];
                    }

                }
            }
            string finalResult = new string(result.Reverse().ToArray());
            Console.WriteLine(finalResult);


        }


        void task2(int n)
        {
            int x = 0;
            List<char> list = new List<char>();
            for (int i = 0; i < n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                list.Add(ch);
            }

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        x++;
                        list.RemoveAt(i);
                        list.RemoveAt(j);
                        i--;
                        break;
                    }
                }
            }
            Console.WriteLine(x);
        }
        void task1(int a, int b, int n)
        {
            int x = 0;
            for (int i = 0; i < b; i++)
            {
                double result = Math.Pow(i, n);
                if (result >= a && result <= b)
                {
                    x++;
                }
            }
            Console.WriteLine(x);
        }
    }
}
