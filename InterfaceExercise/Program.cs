using System.Globalization;
using Entities;
using Services;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data:");
            
            Console.Write("Contract ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(
                Console.ReadLine(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture
                );

            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter number of Installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(id, date, value);
            ContractService service = new ContractService(new PaypalService());

            service.ProcessContract(contract, months);

            Console.WriteLine("Installments: ");
            foreach(Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
