using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt
{
    class Intern_Employee : Employee
    {
        private int InternshipDuration;
        private EmployeeType EmpType;

        public Intern_Employee(string name, string deptt, double basicSalary, int duration)
            :base(name, deptt, basicSalary)
        {
            this.InternshipDuration = duration;
            this.EmpType = EmployeeType.INTERN;
        }

        public int PInternshipDuration
        {
            get
            {
                return this.InternshipDuration;
            }
            set
            {
                this.InternshipDuration = value;
            }
        }

        public EmployeeType PEmpType
        {
            get
            {
                return this.EmpType;
            }
        }

        public override double CalculateSalary()
        {
            return this.BasicSalary;
        }

        public override string ToString()
        {
            Console.WriteLine("\n-------Intern-------");
            return base.ToString() + "\nNet Salary : " + this.CalculateSalary() + "\nInternship Duration : " + this.InternshipDuration + " months\n---------------\n";
        }
    }
}