namespace TaxCalculator
{
    public class Tax
    {
        public static decimal Calculate(decimal income, decimal[] table)
        {
            decimal result = 0M;

            for (int i = table.Length - 2; i >= 0; i-=2)
            {
                decimal taxBracket = table[i];
                decimal taxRate = table[i+1];

                if (income > taxBracket)
                {
                    result += (income - taxBracket) * taxRate;
                    income = taxBracket;
                }
            }

            return decimal.Round(result, 2);
        }
    }
}