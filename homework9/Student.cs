using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9

{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Year { get; set; }
        public Student(string name, int age, int year)
        {
            Name = name;
            Age = age;
            Year = year;
        }
        public string subject()
        {
            string[] subjects = { "math", "chemistry", "english", "other" };
            Random random = new Random();
            int randomIndex = random.Next(subjects.Length);
            string randomSubject = subjects[randomIndex];
            return randomSubject;
        }
        public void graduation()
        {
            Console.WriteLine($"{(4 - (2023 - Year))} is left to graduate university ");
        }

    }
}