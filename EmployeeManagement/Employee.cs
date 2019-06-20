using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt
{
    class Employee
    {
        private string Name;
        private readonly int Id;
        private string Deptt;
        protected double BasicSalary;
        private static int IdGen;

        static Employee() {
            Employee.IdGen = 100;
        }

        public Employee(string Name, string Deptt, double BasicSalary)
        {
            this.Id = ++Employee.IdGen;
            this.Name = Name;
            this.Deptt = Deptt;
            this.BasicSalary = BasicSalary;
        }
        
        public string PName
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }

        public int PId
        {
            get
            {
                return this.Id;
            }
        }

        public string PDeptt
        {
            get
            {
                return this.Deptt;
            }
            set
            {
                this.Deptt = value;
            }

        }

        public double PBasicSalary
        {
            get
            {
                return this.BasicSalary;
            }
            set
            {
                this.BasicSalary = value;
            }
        }

        public override string ToString() {
            return "Id : " + this.Id + "\nName : " + this.Name + "\nDeptt. : " + this.Deptt + "\nBasicSalary : " + this.BasicSalary;
        }

        public virtual double CalculateSalary() {
            return BasicSalary;
        }    //eligible to be overridden
        

    }
}
