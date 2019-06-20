using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt
{
    class Permanent_Employee : Employee
    {
        private readonly EmployeeType EmpType;
        private double Bonus;

        public Permanent_Employee(string Name, string Deptt, double BasicSalary, double Bonus)
            : base(Name, Deptt, BasicSalary)
        {
            this.Bonus = Bonus;
            this.EmpType = EmployeeType.CONTRACT;
        }

        public EmployeeType PEmpType
        {
            get
            {
                return this.EmpType;
            }
        
        }

        public double PBonus
        {
            get
            {
                return this.Bonus;
            }
            set
            {
                this.Bonus = value;
            }
        }

        public override string ToString()
        {
            Console.WriteLine("\n-------Permanent employee-------");
            return base.ToString() +  "\nBonus : " + this.Bonus + "\nNet Salary : " + this.CalculateSalary() + "\n---------------\n";
        }

        public override double CalculateSalary()
        {
           // Console.WriteLine("in overridden method - permanent");
            double TDS = this.BasicSalary * 0.15;
            double DA = this.BasicSalary * 0.7;
            return this.BasicSalary + this.Bonus + DA - TDS;
        }
    }
}
