using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    public class Company
    {
        public bool isLocal { get; set; }

        public void Salary(double sum)
        {
            if (isLocal)
            {
                sum -= sum * 0.18;

            }
            else
            {
                sum -= sum * 0.5;
            }
            Console.WriteLine(sum);
        }
    }
}
