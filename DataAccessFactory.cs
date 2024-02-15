namespace solid_ex_DIP;

public class DataAccessFactory
{
    public static IEmployeeDataAccessLogic GetEmployeeDataAccessObj()
    {
        return new EmployeeDataAccessLogic();
    }
}