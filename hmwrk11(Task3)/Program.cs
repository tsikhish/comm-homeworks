using System;
using System.Collections.Generic;
using System.Xml;

namespace hmwrk11_Task3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var xmlFile = @"C:\Users\Mari\source\repos\homeworkk5\hmwrk11(Task3)\XMLfile.xml";
            var doc = new XmlDocument();
            try
            {
                doc.Load(xmlFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading XML file: {ex.Message}");
                return;
            }
            Console.WriteLine("enter string: ");
            var input = Console.ReadLine();
            Console.WriteLine("enter the number of substrings: ");
            int number = int.Parse(Console.ReadLine());

            List<string> output = new List<string>();
            int startIndex = 0;
            int x = 0;
            for (int i = 0; i < number; i++)
            {
                if (i == number - 1)
                {
                    x = input.Length - startIndex;
                }
                else
                {
                    x = input.Length / number;
                }
                string answer = input.Substring(startIndex, x);
                output.Add(answer);
                startIndex += x;
            }
            XmlNode root = doc.DocumentElement;

            for (int i = 1; i < output.Count - 1; i++)
            {
                Console.WriteLine(output[i]);
                XmlElement el1 = doc.CreateElement(output[i]);
                el1.InnerText = $"string{i}";
                root.AppendChild(el1);
                doc.Save(xmlFile);

            }
        }
    }
}
