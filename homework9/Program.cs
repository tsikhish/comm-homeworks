using System;

namespace homework9
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Company company = new Company();
            //Console.WriteLine("enter company is local or not(true/false): ");
            //bool isLocall = bool.Parse(Console.ReadLine());
            //company.isLocal = isLocall;
            //var employeeInput = userInput();
            //Console.WriteLine("enter the number of working hours");
            //int[] workHours = new int[7];
            //for (int i = 0; i < 7; i++)
            //{
            //    workHours[i] = int.Parse(Console.ReadLine());
            //}
            //Employee user = new Employee(employeeInput.name, employeeInput.surname, employeeInput.age, employeeInput.position, workHours);
            //int averageSalary = user.AverageSalary();
            //company.Salary(averageSalary);
            #endregion
            #region task2
            //var studentInput = studentInfo();
            //Student student = new Student(studentInput.name, studentInput.age, studentInput.year);
            //student.graduation();
            //var teacherInput = teacherInfo();
            //Teacher teacher = new Teacher(teacherInput.name, teacherInput.status);
            //if (teacherInput.status)
            //{
            //    teacher.answer(student.subject());
            //}
            //else
            //{
            //    Console.WriteLine("not certified");
            //}
            #endregion
            #region task3
            Students student = new Students("mariami");
            GoodStudents goodstudent = new GoodStudents("nina");
            LazyStudents lazystudent = new LazyStudents("nika");
            Classroom classroom = new Classroom(student, goodstudent, lazystudent);
            classroom.AllStudents();
            
            #endregion
        }
        public static (string name, bool status) teacherInfo()
        {
            Console.WriteLine("enter teacher's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Is teacher certified or not? (true/false): ");
            bool status = bool.Parse(Console.ReadLine());
            return (name, status);
        }
        public static (string name, int age, int year) studentInfo()
        {
            Console.WriteLine("enter student's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("enter age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the year of enrollment in university: ");
            int year = int.Parse(Console.ReadLine());
            return (name, age, year);
        }
    

        public static (string name, string surname, int age, string position) userInput()
        {
            Console.WriteLine("employee name:");
            string name = Console.ReadLine();
            Console.WriteLine("employee surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("employee age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("employee position: ");
            string position = Console.ReadLine();
            return (name, surname, age, position);
        }
    }
}

