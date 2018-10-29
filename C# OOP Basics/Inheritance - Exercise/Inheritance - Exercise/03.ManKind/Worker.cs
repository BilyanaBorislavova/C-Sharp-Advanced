using System;
using System.Collections.Generic;
using System.Text;

namespace ManKind
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string secondName, decimal weekSalary, int workHoursPerDay)
            :base(firstName, secondName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if(value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if(value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal CalculateSalaryPerHour()
        {
            return (this.WeekSalary / 5) / this.WorkHoursPerDay;
        }

        public override string ToString()
        {
            return $"First Name: {base.FirstName}\nLast Name: {base.SecondName}\nWeek Salary: {this.WeekSalary:f2}\nHours per day: {this.WorkHoursPerDay:f2}\nSalary per hour: {this.CalculateSalaryPerHour():f2}";
        }
    }
}
