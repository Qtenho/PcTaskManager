using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Backend.Data;
using TaskManager.Shared.Entities;

namespace TaskManager.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PcTasksController : ControllerBase
    {
        private readonly DataContext _context;

        public PcTasksController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.PcTasks.ToList());
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var task = _context.PcTasks.FirstOrDefault(x => x.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }

        [HttpPost]
        public IActionResult Post(PcTask pcTask)
        {
            _context.Add(pcTask);
            _context.SaveChanges();
            return Ok(pcTask);
        }

        [HttpPut]
        public IActionResult Put(PcTask pcTask)
        {
            var task = _context.PcTasks.FirstOrDefault(x => x.Id == pcTask.Id);
            if (task == null)
            {
                return NotFound();
            }

            task.DamageDiagnosis = pcTask.DamageDiagnosis;
            task.Comments = pcTask.Comments;
            task.RepairStatus = pcTask.RepairStatus;
            task.RepairValue = pcTask.RepairValue;

            _context.Update(task);
            _context.SaveChanges();
            return Ok(task);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var task = _context.PcTasks.FirstOrDefault(x => x.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            _context.Remove(task);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
