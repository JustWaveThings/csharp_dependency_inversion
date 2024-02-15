using System;

namespace solid_ex_DIP;

public class Program
{
    static void Main(string[] args)
    {
        EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
        Employee emp = employeeBusinessLogic.GetEmployeeDetails(1099);
        Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
        Console.ReadKey();
    }
}

