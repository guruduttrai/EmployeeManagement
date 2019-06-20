using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt
{
    class Contract_Employee : Employee
    {
        private int ContractDuration;
        private readonly EmployeeType EmpType;

        public Contract_Employee(string Name, string Deptt, double BasicSalary, int Duration)
        : base(Name, Deptt, BasicSalary) {  //constructor chaining
            this.ContractDuration = Duration;
            this.EmpType = EmployeeType.CONTRACT;
        }

        public int PContractDuration {
            get
            {
                return this.ContractDuration;
            }
            set
            {
                this.ContractDuration = value;
            }
        }

        public EmployeeType PEmpType
        {
            get
            {
                return this.EmpType;
            }
        }

        public override string ToString()
        {
            Console.WriteLine("\n-------Contractual Employee-------");
            return base.ToString() + "\nNet Salary : " + this.CalculateSalary() +"\nContract Duration : " + this.ContractDuration + " months\n---------------\n";
        }

        public override double CalculateSalary()
        {
            //Console.WriteLine("in overridden method - contract");
            double TDS = this.BasicSalary * 0.15;
            double DA = this.BasicSalary * 0.5;
            return this.BasicSalary + DA - TDS;
        }

    }
}
