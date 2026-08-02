using System;

namespace EmployeePayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================");
            Console.WriteLine("      Employee Payroll");
            Console.WriteLine("================================");

            Console.WriteLine("1. Full-Time Employee");
            Console.WriteLine("2. Part-Time Employee");

            Console.Write("\nEnter Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            EmployeeInfo employee = null;
            IPayroll payroll = null;

            switch (choice)
            {
                case 1:
                    employee = new FullTimeEmployee();
                    payroll = (IPayroll)employee;
                    break;

                case 2:
                    employee = new PartTimeEmployee();
                    payroll = (IPayroll)employee;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            if (employee != null)
            {
                employee.GetEmployeeDetails();
                employee.ShowEmployeeDetails();
                payroll.CalculateSalary();
            }

            Console.ReadKey();
        }

        interface IPayroll
        {
            void CalculateSalary();
        }

        class EmployeeInfo
        {
            protected int empId;
            protected string empName;
            protected double basicSalary;

            public EmployeeInfo()
            {
                Console.WriteLine("\nEnter Employee Details");
            }

            public void GetEmployeeDetails()
            {
                Console.Write("Employee ID : ");
                empId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Employee Name : ");
                empName = Console.ReadLine();

                Console.Write("Basic Salary : ");
                basicSalary = Convert.ToDouble(Console.ReadLine());
            }

            public void ShowEmployeeDetails()
            {
                Console.WriteLine("\n----- Employee Information -----");
                Console.WriteLine($"ID      : {empId}");
                Console.WriteLine($"Name    : {empName}");
                Console.WriteLine($"Salary  : {basicSalary}");
            }
        }

        class FullTimeEmployee : EmployeeInfo, IPayroll
        {
            public void CalculateSalary()
            {
                double da = basicSalary * 0.20;
                double hra = basicSalary * 0.40;
                double medical = basicSalary * 0.10;
                double pf = basicSalary * 0.12;

                double finalSalary = basicSalary + da + hra + medical - pf;

                Console.WriteLine("\n----- Salary Slip -----");
                Console.WriteLine("Employee Type : Full-Time");
                Console.WriteLine($"Basic Salary  : {basicSalary}");
                Console.WriteLine($"DA            : {da}");
                Console.WriteLine($"HRA           : {hra}");
                Console.WriteLine($"Medical       : {medical}");
                Console.WriteLine($"PF Deduction  : {pf}");
                Console.WriteLine($"Net Salary    : {finalSalary}");
            }
        }

        class PartTimeEmployee : EmployeeInfo, IPayroll
        {
            public void CalculateSalary()
            {
                Console.WriteLine("\n----- Salary Slip -----");
                Console.WriteLine("Employee Type : Part-Time");
                Console.WriteLine($"Basic Salary  : {basicSalary}");
                Console.WriteLine($"Net Salary    : {basicSalary}");
            }
        }
    }
}