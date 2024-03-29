﻿namespace Lab5
{
    public abstract class AbstractTeacher
    {
        public string IdentilyNumber { get; set; }
        public string name { get; set; }
        public double BaseSalary { get; set; }
        public int Level { get; set; }
        public bool IsSenior { get; set; }
        public double Bonus { get; set; }
        public abstract double CalculateSalary();
    }
}