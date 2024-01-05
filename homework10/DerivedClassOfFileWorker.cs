using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10
{
    internal class DerivedClassOfFileWorker : FileWorker
    {
        string param = "";
        public override string Param
        {
            get => param; set => param = value;
        }
        public override void Read()
        { Console.WriteLine($"I Can Read to {param} file with max storage {maxStorage}"); }

        public override void Write()
        { Console.WriteLine($"I Can write to {param} file with max storage {maxStorage}"); }

        public override void Edit()
        { Console.WriteLine($"I Can Edit to {param} file with max storage {maxStorage}"); }

        public override void Delete()
        { Console.WriteLine($"I Can Delete to {param} file with max storage {maxStorage}"); }

    }
}
