
using System;
using System.IO;

namespace hmwrk11_Task4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"C:\Users\Mari\source\repos\homeworkk5\hmwrk11(Task4)\text.json");
            var jsonString=stream.ReadToEnd();
            Console.WriteLine(jsonString);
        }
    }
}
