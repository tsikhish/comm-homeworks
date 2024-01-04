using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    internal class Teacher
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        public Teacher(string name, bool status)
        {
            Name = name;
            Status = status;
        }
        public void answer(string sub)
        {
            int sum = 0;
            if (sub == "math")
            {
                Random random = new Random();
                Console.WriteLine($"the subject is math and the sum of two random numbers  is {random.Next(100) + random.Next(100)}");
            }
            else if (sub == "chemistry")
            {
                Console.WriteLine($"the subject is chemistry and the result is H20");
            }
            else if (sub == "english")
            {
                Console.WriteLine($"the subject is english and the result is 'hello,i am mariami'");
            }
            else
            {
                Console.WriteLine("i don't know the subject");
            }
        }
    }
}

