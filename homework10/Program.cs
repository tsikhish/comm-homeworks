﻿
using System;

namespace homework10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1 
            //var result = new DerivedClassOfFileWorker
            //{

            //    maxStorage = 128,
            //    Param = "txt",
            //};
            //result.Read();
            //result.Write();
            //result.Edit();
            //result.Delete();
            #endregion
            #region Task2
            var bank = new Bank();
            bank.CalculateLoanPercent(12, 10);

            var microfinance = new MicroFinance();
            microfinance.CalculateLoanPercent(12, 10);

            #endregion
        }
    }
}
