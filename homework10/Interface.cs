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
         public class Bank : FinanceOperations
        {
            public bool CheckUserHistory()
            {

                Random random = new Random();
                bool randBool = random.Next(2) == 0;
            Console.WriteLine(randBool);
            return randBool;

            }
            public void CalculateLoanPercent(int month, double AmountPerMonth)
            {
                if (CheckUserHistory())
                {
                Console.WriteLine($"Bank: {month * AmountPerMonth * 0.05}");
                }
                else
                {
                    Console.WriteLine("no result");
                }

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


