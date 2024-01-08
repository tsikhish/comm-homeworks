using Newtonsoft.Json;
using System;
using System.IO;

namespace hmwork11_Task4_
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader(@"C:\Users\Mari\source\repos\homeworkk5\hmwork11(Task4)\JsonFile.json");
            var jsonString = r.ReadToEnd();
            Console.WriteLine(jsonString);
            var myJsonClass = JsonConvert.DeserializeObject<JsonClass>(jsonString);
            int daysLeft = int.Parse(myJsonClass.birthday.Substring(5, 2)) - int.Parse(myJsonClass.currentDate.Substring(5, 2));
            Console.WriteLine(daysLeft);

        }
    }
}
