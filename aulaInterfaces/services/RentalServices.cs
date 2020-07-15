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

        private ITaxServices _taxservices;


        public RentalServices(double pricePerHour, double priceperday, ITaxServices taxservices)
        {
            PricePerHour = pricePerHour;
            Priceperday = priceperday;
            _taxservices = taxservices;
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

            double tax = _taxservices.Tax(basicPaymente);

            carRental.Invoice = new Invoice(basicPaymente, tax);

        }

    }
}
