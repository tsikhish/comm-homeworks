using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    internal class Students
    {
        public string Name { get; set; }
        public Students(string name)
        {
            Name = name;
        }
        public virtual string Study()
        {
            return $"{Name} this is student's study method";
        }
        public virtual string Read()
        {
            return $"{Name} this is student's Read method";
        }
        public virtual string Write()
        {
            return $"{Name} this is student's Write method";
        }
        public virtual string Relax()
        {
            return $"{Name} this is student's Relax method";
        }
    }
}
