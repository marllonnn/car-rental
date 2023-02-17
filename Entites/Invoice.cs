using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Entites
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment()
        {
            return BasicPayment + Tax;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Invoice: ");
            sb.AppendLine($"Basic payment: {BasicPayment.ToString("F2")}");
            sb.AppendLine($"Tax: {Tax.ToString("F2")}");
            sb.AppendLine($"Total payment: {TotalPayment().ToString("F2")}");
            return sb.ToString();

        }


    }
}
