using Model;
namespace BusinessLogic
{
    public class BAL
    {
        public static Employee GetEmployee(int EmpNo)
        {
            var employee = DataLayer.DAL.GetEmployee(EmpNo);
            employee.EmpNo = employee.EmpNo;
            return employee;
        }
    }
}
