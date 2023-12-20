using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;

namespace practisefor_hom6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            /*int number;
            bool isValid=int.TryParse(Console.ReadLine(),out number);
            if (isValid)
            {
                var inputArray = new int[number];
                for (int i = 0; i < number; i++)
                {
                    var arrayInput = Console.ReadLine();
                    bool isvalidarray = int.TryParse(arrayInput, out inputArray[i]);
                    if (!isvalidarray)
                    {
                        Console.WriteLine("is not valid");
                        i--;
                    }
                }
                var firstArray = new int[number];
                var secondArray = new int[number];
                int firsArrtIndex = 0;
                int secondArrIndex = 0;
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i] % 2 == 0)
                    {
                        firstArray[firsArrtIndex] = inputArray[i];
                        firsArrtIndex++;
                    }
                    else
                    {
                        secondArray[secondArrIndex] = inputArray[i];
                        secondArrIndex++;
                    }
                }
                foreach (var item in firstArray)
                {
                    Console.WriteLine(item);

                }
                foreach (var item in secondArray)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("isn't valid");
            } */
            #endregion
            #region Task2
            /* List<int> numbers = new List<int>();
               if (int.TryParse(Console.ReadLine(), out int number2))
               {
                   for (int i = 0; i < number2; i++)
                   {
                       if (int.TryParse(Console.ReadLine(), out int element))
                       {
                           numbers.Add(element);
                       }
                       else
                       {
                           Console.WriteLine("Invalid input.");
                           i--;
                       }
                   }
                   var sortedNumbers = numbers.OrderBy(x => x).ToList();
                   for (int i = 0; i < sortedNumbers.Count; i++)
                   {
                       int count = 1;
                       int sum = sortedNumbers[i];
                       while (i < sortedNumbers.Count - 1 && sortedNumbers[i] == sortedNumbers[i + 1])
                       {
                           count++;
                           i++;
                           sum += sortedNumbers[i];
                       }
                       Console.WriteLine($"{sortedNumbers[i]} appears {count} times, sum {sum}");
                   }
               }
               else
               {
                   Console.WriteLine("Invalid input. Please enter a valid integer for the number of elements.");
               }
           }*/
            #endregion
            #region Task3
            /*List<int> numbers = new List<int> {1,2,5,6,1,3,7};
            int n = int.Parse(Console.ReadLine());
            numbers = numbers.OrderBy(x => x).ToList();
            numbers = numbers.Skip(numbers.Count - n).ToList();
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            */
            #endregion
        }
    }
}

