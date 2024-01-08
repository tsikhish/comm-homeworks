using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace hmwrk11_Task3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var xmlFile = @"C:\Users\Mari\source\repos\homeworkk5\hmwrk11(Task3)\XMLfile.xml";
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
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement root = xmlDocument.CreateElement("ROOT");
            xmlDocument.AppendChild(root);
            foreach (var nodes in output)
            {
                XmlNode node1 = xmlDocument.CreateElement($"{nodes}");
                node1.InnerText = $" {nodes.First()}";
                root.AppendChild(node1);
            }
            xmlDocument.Save(xmlFile);

        }
    }
}
