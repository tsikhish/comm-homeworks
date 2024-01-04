using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    internal class LazyStudents : Students
    {
        public LazyStudents(string name) : base(name)
        {
            Name = name;
        }
        public override string Study()
        {
            return $"{Name} study-LazyStudent";
        }
        public override string Read()
        {
            return $"{Name} Read-LazyStudent";
        }
        public override string Write()
        {
            return $"{Name} Write-LazyStudent";
        }
        public override string Relax()
        {
            return $"{Name} Relax-LazyStudent";
        }
    }
}
