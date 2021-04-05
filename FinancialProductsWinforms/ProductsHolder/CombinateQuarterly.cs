﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialProductsWinforms.ProductsHolder
{
    class CombinateQuarterly : ProductBase
    {
        public double SavingTime { get; set; }
        public double NumberOfDeposits { get; set; }

        public CombinateQuarterly (double amountOfInvestment, double interestRate, double savingTime, double numberOfDeposits) : base (amountOfInvestment, interestRate)
        {
            SavingTime = savingTime;
            NumberOfDeposits = numberOfDeposits;
        }
    }
}
