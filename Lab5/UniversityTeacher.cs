namespace Lab5
{
    public class UniversityTeacher : AbstractTeacher
    {
        public string UniversityCode { get; set; }

        public int Englishlevel { get; set; }

        public override double CalculateSalary()
        {
            if (Bonus > 10000)
            {
                throw new AmountException("Bunus is more than 10,000", name);
            }

            var salary = BaseSalary * Level + ((BaseSalary / 10) * Englishlevel) + Bonus;
            if (IsSenior && salary < 60000)
            {
                throw new AmountException("Senior lecturer gets less than 60,000 salary", name);
            }

            return salary;
        }
    }
}

