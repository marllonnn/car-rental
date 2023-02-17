using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1.Entites;

namespace Test1.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        private ITaxServices _taxServices;

        public RentalService(double pricePerHour, double pricePerDay, ITaxServices taxServices)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxServices = taxServices;
        }


        public void ProcessInvoice (CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0;

            if(duration.TotalHours <= 12 )
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxServices.Tax(basicPayment);


            carRental.Invoice = new Invoice(basicPayment, tax);

        }


    }
}
