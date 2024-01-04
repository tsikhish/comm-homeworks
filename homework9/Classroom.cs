using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    internal class Classroom
    {
        public List<Students> Students { get; set; }
        public Classroom(params Students[] students)
        {
            Students = new List<Students>(students);
        }
        public void AllStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine(student.Study());
                Console.WriteLine(student.Read());
                Console.WriteLine(student.Write());
                Console.WriteLine(student.Relax());

            }
        }
    }
}
