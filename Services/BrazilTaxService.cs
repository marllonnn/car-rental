using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1.Services;

namespace Test1.Services
{
    internal class BrazilTaxService : ITaxServices
    {
        public double Tax(double amount)
        {
           if (amount <= 100)
            {
                return amount * 0.20;
            } else
            {
                return amount * 0.15;
            }



        }
    }
}
