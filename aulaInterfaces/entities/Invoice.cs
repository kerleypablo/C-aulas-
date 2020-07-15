using System.Collections.Generic;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace aulaInterfaces.entities
{
    class Invoice
    {

        public double basicPayment { get; set; }

        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            this.basicPayment = basicPayment;
            Tax = tax;
        }



        public double TotalPayment
        {
            get { return basicPayment + Tax; }
        }


        public override string ToString()
        {
            return "Basic Payment:"
                + basicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
