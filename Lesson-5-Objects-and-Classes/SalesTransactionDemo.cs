namespace SalesTransactionDemo
{
    public class SalesTransaction
    {
        private string salesPerson;
        private decimal salesAmount;
        private decimal commissionRate;
        private readonly decimal totalCommission;
        
        public string Person
        {
            get { return salesPerson; }
            set { salesPerson = value; }
        }

        public decimal SalesAmount
        {
            get { return salesAmount; }
            set { salesAmount = value; }
        }

        public decimal CommissionRate
        {
            get { return commissionRate; }
            set { commissionRate = value; }
        }

        public decimal TotalCommission
        {
            get { return totalCommission; }
        }

        public SalesTransaction(string person)
        {
            salesPerson = person;
            salesAmount = 0;
            commissionRate = 0;
            totalCommission = 0;
        }

        public SalesTransaction(string person, decimal amount)
        {
            salesPerson = person;
            salesAmount = amount;
            commissionRate = 0;
            totalCommission = 0;
        }

        public SalesTransaction(string person, decimal amount, decimal rate)
        {
            salesPerson = person;
            salesAmount = amount;
            commissionRate = rate;
            totalCommission = amount * rate;
        }

        public static decimal operator +(SalesTransaction a, SalesTransaction b)
        {
            return a.salesAmount + b.salesAmount;
        }
    }
}