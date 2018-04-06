using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Projects.Models;
using DBServices.Models;
using Microsoft.AspNetCore.Authorization;
using Employees.Models;

namespace ProjectsApi.Controllers
{
    [Route("api/[controller]")]
    public class ProjectsController : Controller
    {
        private readonly DBservice _context;

        public ProjectsController(DBservice context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Project> GetAll()
        {
            return _context.Projects.ToList();
        }
        [HttpGet("{id:int}")]
        public List<Project> GetProject(int id)
        {
            var value = from proj in _context.Projects where proj.Id == id select proj;

            return value.ToList();
        }
        [HttpPost]
        [Route("~/api/openProjects")]
        public List<Project> GetOpenProjectsForUser([FromBody] Employee employee)
        {
            var value = 
            from proj in _context.Projects 
            join apt in _context.ActualProjectsTasks on proj.Id equals apt.Project 
            join at in  _context.ActualTasks on  apt.Actual_task equals at.Id  
            join emp in _context.Employees on at.Assign_to equals emp.Id 
            where emp.Id==employee.Id select proj;

            return value.ToList();
        }

    }
}
