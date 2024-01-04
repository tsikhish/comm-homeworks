using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    internal class GoodStudents : Students
    {
        public GoodStudents(string name) : base(name)
        {
            Name = name;
        }
        public override string Study()
        {
            return $"{Name} study-GoodStudent";
        }
        public override string Read()
        {
            return $"{Name} Read-GoodStudent";
        }
        public override string Write()
        {
            return $"{Name} Write-GoodStudent";
        }
        public override string Relax()
        {
            return $"{Name} Relax-GoodStudent";
        }
    }
}
