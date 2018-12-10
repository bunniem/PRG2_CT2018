using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_CT2018
{
    class FullTimeEmployee:Employee
    {
        // Attributes
        private double basicPay;
        private double allowance;

        // Properties
        public double BasicPay
        {
            get { return basicPay; }
            set { basicPay = value; }
        }

        public double Allowance
        {
            get { return allowance; }
            set { allowance = value; }
        }

        // Constructors
        public FullTimeEmployee() : base(){ }

        public FullTimeEmployee(int i, string n, double b, double a):base(i, n)
        {
            BasicPay = b;
            Allowance = a;
        }

        // Methods
        public override double CalculatePay()
        {
            return basicPay + allowance;
        }

        public override string ToString()
        {
            return base.ToString() + $"\t{BasicPay}\t{Allowance}";
        }
    }
}
