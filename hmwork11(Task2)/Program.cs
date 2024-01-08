using System;
using System.IO;

namespace hmwork11_Task2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputFile = @"C:\Users\Mari\source\repos\homeworkk5\hmwork11(Task2)\fileForTask2\text.txt";
            Console.WriteLine("enter number: ");
            var input = int.Parse(Console.ReadLine());
            int x = 1;
            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    File.AppendAllText(inputFile, Environment.NewLine);
                    File.AppendAllText(inputFile, $" {j} *  {x} = {j * x}" + Environment.NewLine);

                }
                x++;
                File.AppendAllText(inputFile, "------------" + Environment.NewLine);
            }
        }
    }
}

