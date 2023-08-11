using System;
using System.Text.RegularExpressions;

namespace BonusCalculation
{
    class Employee
    {
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public int Salary { get; set; }
        public double Bonus { get; set; }

        public event Action<double> BonusCalculation;

        public void Calculate()
        {
            Bonus = Salary * 3;
            BonusCalculation?.Invoke(Bonus);
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee Count");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Employee employee = new Employee();

                Regex validname = new Regex("^[A-Za-z]{5,}");
                Regex validId = new Regex("^[0-9]{2,}");
                Regex validSalary = new Regex("^[0-9]{5,}");

                try
                {
                    Console.WriteLine("Enter Employee Name");
                    employee.Name = Console.ReadLine();
                    if (!validname.IsMatch(employee.Name) && employee.Name != null)
                    {
                        Console.WriteLine("Invalid Name");
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e}");
                    continue;
                }

                try
                {
                    Console.WriteLine("Enter Employee ID");
                    employee.EmployeeID = Convert.ToInt32(Console.ReadLine());
                    if (!validId.IsMatch(Convert.ToString((employee.EmployeeID))))
                    {
                        Console.WriteLine("Invalid ID");
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e}");
                    continue;
                }

                try
                {
                    Console.WriteLine("Enter Salary");
                    employee.Salary = Convert.ToInt32(Console.ReadLine());
                    if (!validSalary.IsMatch(Convert.ToString((employee.Salary))))
                    {
                        Console.WriteLine("Invalid salary");
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e}");
                    continue;
                }

                employee.BonusCalculation += (bonus) =>
                {
                    Console.WriteLine($"Bonus for Employee {employee.Name}: {bonus}");
                };
                employee.Calculate();

                Console.WriteLine("Employee Details");
                Console.WriteLine($"Employee Name: {employee.Name}");
                Console.WriteLine($"Employee EmployeeId: {employee.EmployeeID}");
                Console.WriteLine($"Employee Salary: {employee.Salary}");
                Console.WriteLine($"Employee Bonus: {employee.Bonus}");
            }

            Console.ReadLine();
        }
    }
}
