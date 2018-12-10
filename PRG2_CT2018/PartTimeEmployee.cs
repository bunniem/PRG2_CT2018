using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_CT2018
{
    class PartTimeEmployee:Employee
    {
        // Attributes
        private double dailyRate;
        private int daysWorked;

        // Properties
        public double DailyRate
        {
            get { return dailyRate; }
            set { dailyRate = value; }
        }

        public int DaysWorked
        {
            get { return daysWorked; }
            set { daysWorked = value; }
        }

        // Constructors
        public PartTimeEmployee() : base() { }

        public PartTimeEmployee(int i, string n, double d, int w) : base(i, n)
        {
            DailyRate = d;
            DaysWorked = w;
        }

        // Methods
        public override double CalculatePay()
        {
            return DaysWorked * DailyRate;
        }

        public override string ToString()
        {
            return base.ToString() + $"\t{DailyRate}\t{DaysWorked}";
        }
    }
}
