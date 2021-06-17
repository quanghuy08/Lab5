
namespace Lab5
{
    public class HighSchoolTeacher : AbstractTeacher
    {
        public string HighSchoolCode { get; set; }

        public override double CalculateSalary()
        {
            if (Bonus > 10000)
            {
                throw new AmountException("Bonus is  more than 10,000", name);
            }

            var salary = BaseSalary * Level + Bonus;
            if (IsSenior && salary < 60000)
            {
                throw new AmountException("Senior Lecturer  gets less than 60,000 salary",name);
            }

            return salary;
        }
    }
}