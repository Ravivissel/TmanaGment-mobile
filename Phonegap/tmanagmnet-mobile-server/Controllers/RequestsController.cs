using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Requests.Models;
using DBServices.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
using Newtonsoft.Json;

namespace RequestsApi.Controllers
{

    [Route("api/[controller]")]
    public class RequestsController : Controller
    {
        private readonly DBservice _context;

        public RequestsController(DBservice context)
        {
            _context = context;

            if (_context.Requests.Count() == 0)
            {
                _context.SaveChanges();
            }
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _context.Requests.ToList();
            if (!result.Any())
            {
                return NotFound(result);
            }
            return Ok(result);
        }
        [HttpGet("{id:int}")]
        public List<Request> Get(int id)
        {
            var value = from req in _context.Requests where req.Id == id select req;

            return value.ToList();
        }

        [HttpPut]
        public JsonResult PutRequest([FromBody]Request request)
        {
            if (request == null)
            {
                throw new System.ArgumentNullException(nameof(request));
            }

            try
            {
                var excluded = new[] { "Id", "Created_at" };
                var entry = _context.Entry(request);
                entry.State = EntityState.Modified;
                foreach (var name in excluded)
                {
                    entry.Property(name).IsModified = false;
                }
                _context.SaveChanges();

                return Json("Response from Edit");
            }
            catch (DbUpdateException DbUpdateException)
            {
                return Json(DbUpdateException);

            }

        }

    }
}
