using System;
using System.Collections;
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
            /*int r = int.Parse(Console.ReadLine());
            int sOfSmallSquere=2*r* r;
            int sOfBigSquere=4*r*r;
            int answer = sOfBigSquere - sOfSmallSquere;
            Console.WriteLine(answer);*/
            #endregion
            #region Task2
            /*int z=0;
            List <char> sameElements = new List <char>();
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++){
                char y = Console.ReadLine()[0];
                sameElements.Add(y);
            }
            for(int i = 0;i<sameElements.Count;i++){
                if(sameElements[0]==sameElements[i]){
                    z++;
                }
            }
            if (z == sameElements.Count)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("No");
            }*/
            #endregion
            #region Task3
            /*int mogeba = int.Parse(Console.ReadLine());
            int fre=int.Parse(Console.ReadLine());
            int wageba = int.Parse(Console.ReadLine());
            int answer = mogeba * 3 + fre;
            Console.WriteLine(answer);*/
            #endregion
            #region Task4
            /*int[] arr = new int[7];
            int salary = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int y = int.Parse(Console.ReadLine());
                arr[i] = y;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 8 && i < 5)
                {

                    salary += (arr[i] - 8) * 5 + 80;
                }
                else if (arr[i] <= 8 && i < 5)
                    salary += arr[i] * 10;
                else if (i >= 5)
                {
                    salary += arr[i] * 20;
                }
            }
            Console.WriteLine(salary);*/
            #endregion
            #region Task5
            /*List<int> lst = new List<int>();
            int x = 1;
            int max_ = 0;
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int y = int.Parse(Console.ReadLine());
                lst.Add(y);
            }
            for(int i=0; i < lst.Count-1; i++)
            {
                if (lst[i + 1] > lst[i]) {
                    x++;
                    if (x > max_)
                    {
                        max_ = x;
                    }
                }
                else
                {
                    x = 1;
                }
            }
            Console.WriteLine(max_);*/
            #endregion
            #region Task 6.1
            /*int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            List<string> strings = new List<string>();
            for (int i = 0; i < m; i++)
            {
                string word = Console.ReadLine();
                if (word.Length >= n)
                {
                    strings.Add(word);
                }
            }
            if (strings.Count == 0)
            {
                Console.WriteLine("No elements found");
            }
            foreach (string s in strings) { 
            Console.WriteLine(s);
        }*/
            #endregion
            #region Task6.2
            /*string m = "Hello World I marikunkulaa love Programming";
            int n = 7;
            List<string> lst = new List<string>();
            int x = 0;

            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] != ' ')
                {
                    lst.Add(m[i].ToString());
                    x++;
                    if (x >= n && (i == m.Length - 1 || m[i + 1] == ' '))
                    {
                        Console.WriteLine(string.Join("", lst.ToArray()));
                    }
                }
                else
                {
                    x = 0;
                    lst.Clear();
                }*/
            #endregion
        }
    }
}
