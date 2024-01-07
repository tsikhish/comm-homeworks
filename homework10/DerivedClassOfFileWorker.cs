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
        {
            Console.Write("I Can Read from ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(param);
            Console.ResetColor();
            Console.Write(" file with max storage ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(maxStorage);
            Console.ResetColor();
        }
        public override void Write()
        {
            Console.Write("I Can write from ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(param);
            Console.ResetColor();
            Console.Write("file with max storage ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(maxStorage);
            Console.ResetColor();
        }
        public override void Edit()
        {
            Console.Write("I Can edit from ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(param);
            Console.ResetColor();
            Console.Write(" file with max storage ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(maxStorage);
            Console.ResetColor();
        }
        public override void Delete()
        {
            Console.Write("I Can delete from ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(param);
            Console.ResetColor();
            Console.Write(" file with max storage ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(maxStorage);
            Console.ResetColor();
        }
    }
}
