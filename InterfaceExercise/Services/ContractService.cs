using Entities;
using Services.Interfaces;

namespace Services
{
    class ContractService
    {
        public IOnlinePaymentService PaymentService { get; set; }

        public ContractService(IOnlinePaymentService paymentService)
        {
            PaymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double baseValue = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                double amount = PaymentService.Interest(baseValue, i);
                amount = PaymentService.PaymentFee(amount);

                DateTime installmentDate = contract.Date.AddMonths(i);

                contract.AddInstallment(new Installment(installmentDate, amount));
            }
        }
    }
}
