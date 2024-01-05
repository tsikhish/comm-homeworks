using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10
{
    
        interface FinanceOperations
        {
            void CalculateLoanPercent(int month, double AmountPerMonth);
            bool CheckUserHistory();
        }
        internal class Bank : FinanceOperations
        {
            public bool CheckUserHistory()
            {

                Random random = new Random();
                bool randBool = random.Next(2) == 0;
                return randBool;

            }
            public void CalculateLoanPercent(int month, double AmountPerMonth)
            {

                Console.WriteLine($"Bank: {month * AmountPerMonth * 0.05}");

            }
        }
        internal class MicroFinance : FinanceOperations
        {
            public bool CheckUserHistory()
            {
                return true;
            }
            public void CalculateLoanPercent(int month, double AmountPerMonth)
            {
                Console.WriteLine($"Microfinance: {(4 * month) + (month * AmountPerMonth * 0.01)}");


            }
        }
    }


