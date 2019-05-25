using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QoutesController : ControllerBase
    {
        private ApplicationContext _context;

        public QoutesController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Qoute>> Get()
        {
            return _context.Qoute.ToList();
        }

        [HttpPost]
        public async Task<ActionResult<Qoute>> PostQoute(Qoute qoute)
        {
            _context.Qoute.Add(qoute);
            await _context.SaveChangesAsync();

            return qoute;
        }
    }
}
