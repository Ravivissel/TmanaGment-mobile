using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Employees.Models;
using DBServices.Models;
using Microsoft.AspNetCore.Authorization;

namespace EmployeesApi.Controllers
{
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private readonly DBservice _context;

        public EmployeesController(DBservice context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }
        [HttpGet("{id:int}")]
        public List<Employee> GetEmployee(int id)
        {
            var value = from emp in _context.Employees where emp.Id == id select emp;

            return value.ToList();
        }


        [Route("~/api/Login")]
        [AcceptVerbs("Get", "Post")]
        public bool Login( [FromBody] Employee employee)
        {

            if (!string.IsNullOrEmpty(employee.User_name) && !string.IsNullOrEmpty(employee.Password))
            {
                var user = (from emp in _context.Employees where emp.User_name == employee.User_name && emp.Password == employee.Password select emp).Any();

                if (user)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
