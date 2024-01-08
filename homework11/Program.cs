using System;
using System.IO;
using System.Linq;

namespace homework11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputFile = @"C:\Users\Mari\source\repos\homeworkk5\homework11\fileForTask1\text.txt";
            Console.WriteLine("enter the number of words: ");
            var input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("enter the word: ");
                string sentence = Console.ReadLine();
                File.AppendAllText(inputFile, sentence + Environment.NewLine);
            }
            string[] strings = File.ReadAllLines(inputFile);
            if (strings.Length >= input)
            {
                Console.WriteLine(strings[input - 1]);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
