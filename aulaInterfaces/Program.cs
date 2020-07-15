using System;
using System.Globalization;
using aulaInterfaces.entities;
using aulaInterfaces.services;

namespace aulaInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enetre com o dados do aluguel");
            Console.WriteLine("Car model: ");
            String model = Console.ReadLine();

            Console.WriteLine("data de Retirada :");
            DateTime DataRetirada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("data de entrega :");
            DateTime DataEntrega = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);



            Console.WriteLine("preço por hora: ");
            double Phora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("preço por dia: ");
            double Pday = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            CarRental carRental = new CarRental(DataRetirada, DataEntrega, new veiculo(model));

            RentalServices rentalService = new RentalServices(Phora, Pday, new BrasulTaxservices());


            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("Invoice:");
            Console.WriteLine(carRental.Invoice);


        }
    }
}
