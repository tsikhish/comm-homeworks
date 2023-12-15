using System;

namespace homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            /*int x = int.Parse(Console.ReadLine());
            if (x%5==0) Console.WriteLine("Yes");
                else Console.WriteLine("No");*/
            int x = int.Parse(Console.ReadLine());
            var result = x % 5 == 0 ? "Yes"
                : "No";
            Console.WriteLine(result);
            #endregion
            #region Task2
            int x, y;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            if (x != 0)
            {
                if (x > y)
                {
                    Console.WriteLine(x + y);
                    Console.WriteLine(x - y);
                    Console.WriteLine(x * y);
                    Console.WriteLine(x / y);
                }
                else
                {
                    Console.WriteLine(x + y);
                    Console.WriteLine(y - x);
                    Console.WriteLine(y * x);
                    Console.WriteLine(y / x);
                }
            }
            else
            {
                Console.WriteLine("Not allowed todivide by zero");
                Console.ForegroundColor
            }
            #endregion
            #region Task3
            int z, x, y;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = x;
            x = y;
            y = z;
            Console.WriteLine(x);
            Console.WriteLine(y);
            #endregion
            #region Task4
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{x}*{i}={x * i}");
            }
            #endregion
            #region Task5
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i * i);
                }
            }
            #endregion
        }
    }