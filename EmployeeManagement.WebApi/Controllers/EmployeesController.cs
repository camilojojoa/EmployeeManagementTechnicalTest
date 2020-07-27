using EmployeeManagement.BusinessLogic;
using EmployeeManagement.ViewModels;
using System.Collections.Generic;
using System.Web.Http;


namespace EmployeeManagement.WebApi.Controllers
{
    public class EmployeesController : ApiController
    {
        [HttpGet]
        public List<EmployeeViewModel> GetEmployees()
        {
            return EmployeeBusiness.GetEmployeesInformation();
        }

        [HttpGet] 
        public EmployeeViewModel GetEmployee(int id)
        {
            return EmployeeBusiness.GetEmployeeInformation(id);
        }
    }
}
