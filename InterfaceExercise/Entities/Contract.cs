namespace Entities
{
    class Contract
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int id, DateTime date, double totalValue)
        {
            Id = id;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment) { 
            Installments.Add(installment); 
        }
    }
}
