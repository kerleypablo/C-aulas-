using System;
using System.Collections.Generic;
using System.Text;

namespace aulaInterfaces.entities
{
    class CarRental
    {

        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public veiculo Veiculo { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, veiculo veiculo)
        {
            Start = start;
            Finish = finish;
            Veiculo = veiculo;
        }



    }
}
