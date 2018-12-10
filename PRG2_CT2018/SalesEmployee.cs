using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_CT2018
{
    class SalesEmployee:FullTimeEmployee
    {
        // Attributes
        private double salesAmount;

        // Properties
        public double SalesAmount
        {
            get { return salesAmount; }
            set { salesAmount = value; }
        }

        // Constructors
        public SalesEmployee() : base() { }

        public SalesEmployee(int i, string n, double b, double a, double s) :base(i, n, b, a)
        {
            SalesAmount = s;
        }

        // Methods
        public double DetermineCommissionRate()
        {
            // Details are not given in qns
            if(SalesAmount <= 5000)
            {
                return 0.10;
            }
            else if(SalesAmount <= 10000)
            {
                return 0.20;
            }
            return 0.30;
        }
        public override double CalculatePay()
        {
            return base.CalculatePay() + (salesAmount * DetermineCommissionRate());
        }

        public override string ToString()
        {
            return base.ToString() + $"\t{SalesAmount}";
        }
    }
}
