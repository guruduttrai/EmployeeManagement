using System;
using System.Collections.Generic;

namespace EmpMgmt
{
    class EmployeeManagement
    {
        static void Main( String [] args)
        {
            List<Employee> list = new List<Employee>();
            bool flag = false;  //to drive while loop

            while(!flag)
            {
                try
                {
                    Console.WriteLine("=======Alphabet Inc.=======");
                    Console.WriteLine("1. Add Employee\n2. Terminate Employee\n3. List all Employees\n4. Search Employee\n5. Exit\n");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("1. Permanent Employee\n2. Contract Employee\n");
                            int HireType = Convert.ToInt32(Console.ReadLine());
                            switch (HireType)
                            {
                                case 1:
                                    Console.WriteLine("Enter Name, Deptt, Basic and Bonus for Permanent Employee");
                                    string Name = Console.ReadLine();
                                    string Deptt = Console.ReadLine();
                                    double BasicSalary = Convert.ToInt32(Console.ReadLine());
                                    double Bonus = Convert.ToDouble(Console.ReadLine());

                                    Employee perm = new Permanent_Employee(Name, Deptt, BasicSalary, Bonus);
                                    list.Add(perm);
                                    Console.WriteLine("Permanent Employee added successfully!");

                                    break;

                                case 2:
                                    Console.WriteLine("Enter Name, Deptt, Basic and Contract Duration in months for Contractual Employee");
                                    string CName = Console.ReadLine();
                                    string CDeptt = Console.ReadLine();
                                    double CBasicSalary = Convert.ToInt32(Console.ReadLine());
                                    int CDuration = Convert.ToInt32(Console.ReadLine());

                                    Employee contract = new Contract_Employee(CName, CDeptt, CBasicSalary, CDuration);
                                    list.Add(contract);
                                    Console.WriteLine("Contractual Employee added successfully!");
                                    break;

                                default:
                                    Console.WriteLine("Invalid Employee Type selected...");
                                    break;
                            }
                            break;

                        case 2:
                            Console.WriteLine("Enter the ID of Employee to be removed : ");
                            int IdToBeRemoved = Convert.ToInt32(Console.ReadLine());
                            Employee ToBeRemoved = list.Find(e => e.PId == IdToBeRemoved); //return an employee whose PId matches PId given by user

                            if (ToBeRemoved == null)
                            {
                                Console.WriteLine("No Employee found with given Id.");
                            }
                            else
                            {
                                list.Remove(ToBeRemoved);
                                Console.WriteLine("Employee with Id " + IdToBeRemoved + " removed successfully!");
                            }
                            break;

                        case 3:
                            list.ForEach(emp => Console.WriteLine(emp));
                            break;

                        case 4:
                            Console.WriteLine("Enter the ID of Employee to be searched : ");
                            int IdToBeSearched = Convert.ToInt32(Console.ReadLine());
                            Employee RelevantEmployee = list.Find(e => e.PId == IdToBeSearched); //return an employee whose PId matches PId given by user

                            if (RelevantEmployee == null)
                            {
                                Console.WriteLine("No Employee found with given Id.");
                            }
                            else
                            {
                                Console.WriteLine("Employee Details : " + RelevantEmployee); ;
                            }
                            break;

                        case 5:
                            Console.WriteLine("Thanks for using the program...");
                            flag = true;
                            break;

                        default:
                            Console.WriteLine("Invalid option selected, please try again!");
                            break;

                    }   //outer switch ends here

                } catch(Exception e)
                {
                    Console.Error.WriteLine("\nException caught : " + e.Message + "\n");
                }
            }   //while loop ends here
        }// end of main
    }
}
