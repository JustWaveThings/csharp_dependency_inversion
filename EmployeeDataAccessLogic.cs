namespace solid_ex_DIP;

public class EmployeeDataAccessLogic : IEmployeeDataAccessLogic
{
    public Employee GetEmployeeDetails(int id)
    {
        // this should hit a database but for now just hardcode
        Employee emp = new Employee()
        {
            ID = id,
            Name = "Fred",
            Department = "Software Development",
            Salary = 125000
        };
        return emp;
    }
}