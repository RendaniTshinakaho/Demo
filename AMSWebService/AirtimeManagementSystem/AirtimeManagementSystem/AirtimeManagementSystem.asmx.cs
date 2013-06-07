using System.Web.Services;
namespace AirtimeManagementSystem
{
    /// <summary>
    /// Summary description for AirtimeManagementService
    /// </summary>
    [WebService(Namespace = "http://www.crs.co.za")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {
        [WebMethod]
        public Model.Employee GetEmployee(int empId)
        {
            var emp = BusinessLogic.BAL.GetEmployee(empId);
            return emp;
        }
    }
}