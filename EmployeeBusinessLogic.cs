namespace solid_ex_DIP;

public class EmployeeBusinessLogic
{
    IEmployeeDataAccessLogic _IEmployeeDataAccessLogic;

    public EmployeeBusinessLogic()
    {
        _IEmployeeDataAccessLogic = DataAccessFactory.GetEmployeeDataAccessObj();
    }

    public Employee GetEmployeeDetails(int id)
    {
        return _IEmployeeDataAccessLogic.GetEmployeeDetails(id);
    }
}