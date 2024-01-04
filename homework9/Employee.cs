using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace homework9
{
    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        private int[] WorkHours;

        public Employee(string name, string surname, int age, string position, int[] workHours)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Position = position;
            WorkHours = workHours;
        }


        public int AverageSalary()
        {
            int salary = 0;
            int sumOfWorkingHours = 0;
        
            for (int i = 0; i < WorkHours.Length; i++)
            {
                if(i==5 || i==6)
                {
                    if (Position == "meneger")
                    {
                        salary += 80 * WorkHours[i];
                    }
                    else if (Position == "developer")
                    {
                        salary += 60 * WorkHours[i];
                    }
                    else if (Position == "tester")
                    {
                        salary += 40 * WorkHours[i];
                    }
                    else
                    {
                        salary += 20 * WorkHours[i];
                    }
                    Console.WriteLine($"weekendis chatvlit {salary}");

                }
                else
                {
                    Console.WriteLine(WorkHours[i]);
                    if (WorkHours[i] <= 8)
                    {
                        if (Position == "meneger")
                        {
                            salary += 40 * WorkHours[i];
                        }
                        else if (Position == "developer")
                        {
                            salary += 30 * WorkHours[i];
                        }
                        else if (Position == "tester")
                        {
                            salary += 20 * WorkHours[i];
                            Console.WriteLine($"samushao saati {WorkHours[i]}");
                            Console.WriteLine($"gamomushaveba {salary}");
                        }
                        else
                        {
                            salary += 10 * WorkHours[i];
                        }
                        Console.WriteLine($"wesit igive salary rac testerzea {salary}");

                    }
                    else
                    {
                        if (Position == "meneger")
                        {
                            salary += 40 * 8+(WorkHours[i] - 8) * 5;
                        }
                        else if (Position == "developer")
                        {
                            salary += 30*8+ (WorkHours[i] - 8) * 5;
                        }
                        else if (Position == "tester")
                        {
                            salary += 20*8+ (WorkHours[i] - 8) * 5;
                        }
                        else
                        {
                            salary +=10*8+ (WorkHours[i] - 8) * 5;
                        }
                        Console.WriteLine($"bonusi {salary}");

                    }
                }
                
                sumOfWorkingHours += WorkHours[i];
                Console.WriteLine(sumOfWorkingHours);
                if (sumOfWorkingHours > 50)
                {
                    salary += salary * 1 / 5;
                }
            }
            return salary;
        }

    }
}