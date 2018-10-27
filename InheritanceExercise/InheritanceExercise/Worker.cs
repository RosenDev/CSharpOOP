using System;
using System.Collections.Generic;
using System.Text;

namespace InherterenceExercise
{
    class Worker : Human
    {
        private decimal salaryPerHour;

        public decimal SalaryPerHour
        {
            get => salaryPerHour;
            private set => salaryPerHour = value;
        }

        public override string ToString()
        {
            return $"First Name: {FirstName}\nLast Name: {LastName}\nWeek Salary: {WeekSalary:f2}\nHours per day: {HoursPerDay:f2}\nSalary per hour: {SalaryPerHour:f2}";
        }

        private decimal weekSalary;
        private decimal hoursPerDay;

        public decimal WeekSalary
        {
            get => weekSalary;
            set
            {
                if (value<=10)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
                }

                weekSalary = value;
            }
        }

        public decimal HoursPerDay
        {
            get => hoursPerDay;
            set
            {
                if (value<1||value>12)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
                }

                hoursPerDay = value;
            }
        }

        private decimal GetSalaryPerHour()
        {
            return weekSalary / (5m*hoursPerDay);
        }
        public Worker(string firstName, string lastName,decimal weekSalary,decimal hoursPerDay) : base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            HoursPerDay = hoursPerDay;
            SalaryPerHour = GetSalaryPerHour();
        }
    }
}
