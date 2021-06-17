using System;

namespace Lab5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var highSchoolTeacher = new HighSchoolTeacher
            {
                IdentilyNumber = "ID001",
                name = "Spring Hero",
                BaseSalary = 100,
                Level = 1,
                Bonus = 100,
                IsSenior = false,
                HighSchoolCode = "HS001"
            };
            Console.WriteLine(highSchoolTeacher.CalculateSalary());

            var universityTaecher = new UniversityTeacher
            {
                IdentilyNumber = "ID001",
                name = "Dao Xuan",
                BaseSalary = 60000,
                Level = 1,
                Bonus = 9000,
                IsSenior = true,
                Englishlevel = 2,
                UniversityCode = "UN001"
            };
            Console.WriteLine(universityTaecher.CalculateSalary());
        }
    }
}