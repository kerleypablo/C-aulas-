using System;
using System.Collections.Generic;
using System.Text;
using aulaInterfaces.entities;

namespace aulaInterfaces.services
{
    class RentalServices
    {

        public double PricePerHour { get; private set; }
        public double Priceperday { get; private set; }

        private BrasulTaxservices brazilTaxServices = new BrasulTaxservices();


        public RentalServices(double pricePerHour, double priceperday)
        {
            PricePerHour = pricePerHour;
            Priceperday = priceperday;
        }


        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPaymente = 0.0;
            if ( duration.TotalHours <= 12.0)
            {
                basicPaymente = PricePerHour * Math.Ceiling( duration.TotalHours);
                
            }else
            {
                basicPaymente = Priceperday * Math.Ceiling( duration.TotalDays);
            }

            double tax = brazilTaxServices.Tax(basicPaymente);

            carRental.Invoice = new Invoice(basicPaymente, tax);

        }

    }
}
