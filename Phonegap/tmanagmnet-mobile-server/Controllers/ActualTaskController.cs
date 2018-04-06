using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ActualTasks.Models;
using DBServices.Models;

namespace ActualTasksApi.Controllers
{
    [Route("api/[controller]")]
    public class ActualTasksController : Controller
    {
        private readonly DBservice _context;

        public ActualTasksController(DBservice context)
        {
            _context = context;
        }
        [HttpGet]
        public List<ActualTask> GetAll()
        {
            return  _context.ActualTasks.ToList();
        }
        [HttpGet("{id}", Name = "id")]
        public List<ActualTask> GetActualTaskByID(int id)
        {
            var value = from ActualTask in _context.ActualTasks where ActualTask.Id == id select ActualTask;

            return  value.ToList();
        }
    
    }
}