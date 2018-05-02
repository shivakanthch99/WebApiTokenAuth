using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTokenAuth.Models;

namespace WebApiTokenAuth.Controllers
{
    [RoutePrefix("api/employee")]
    [Authorize]
    public class EmployeeController : ApiController
    {
        [Route]
        [HttpGet]
        public IEnumerable<Employee> GetAllEmployees()
        {
            EmployeeDBEntities emp = new EmployeeDBEntities();
            return emp.Employees;
        }
    }
}
