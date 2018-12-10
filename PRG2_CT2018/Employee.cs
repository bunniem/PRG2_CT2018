using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_CT2018
{
    abstract class Employee:IComparable<Employee>
    {
        // Attributes
        private int id;
        private string name;

        // Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Constructors
        public Employee() { }

        public Employee(int i, string n)
        {
            Id = i;
            Name = n;
        }

        // Methods
        public int CompareTo(Employee emp)
        {
            return Id.CompareTo(emp.Id);
        }

        public abstract double CalculatePay();

        public override string ToString()
        {
            return $"{Id}\t{Name}";

        }
    }
}
