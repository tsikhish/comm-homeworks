using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10
{
    abstract class FileWorker
    {
        public int maxStorage { get; set; }
        public abstract string Param { get; set; }
        public abstract void Read();

        public abstract void Write();
        public abstract void Edit();
        public abstract void Delete();

    }
}
