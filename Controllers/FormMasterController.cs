
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
 

namespace MyProjectApi.Controllers
{
    [Route("api/[controller]")]
    public class FormMasterController : ControllerBase
    {
        private readonly MyDBContext _context;


        public FormMasterController(MyDBContext content)
        {
            _context = content;
        }

        // GET: api/FormMaster
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FormMaster>>> Get()
        {
            return await _context.FormMaster.ToListAsync();
        }

        // GET: api/FormMaster/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FormMaster>> Get(int id)
        {
            var _FormMaster = await _context.FormMaster.FindAsync(id);

            if (_FormMaster == null)
            {
                return NotFound();
            }

            return _FormMaster;
        }

        // PUT: api/FormMaster/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]FormMaster _FormMaster)
        {
            if (id != _FormMaster.Id)
            {
                return BadRequest();
            }

            _context.Entry(_FormMaster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FormMasterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/FormMaster
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [HttpPost]
        public async Task<ActionResult<FormMaster>> Post([FromBody]FormMaster _FormMaster)
        {
            _context.FormMaster.Add(_FormMaster);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetFormMaster", new { id = _FormMaster.Id }, _FormMaster);
            return CreatedAtAction(nameof(Get), new { id = _FormMaster.Id }, _FormMaster);
        }

        // DELETE: api/FormMaster/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FormMaster>> Delete(int id)
        {
            var _FormMaster = await _context.FormMaster.FindAsync(id);
            if (_FormMaster == null)
            {
                return NotFound();
            }

            _context.FormMaster.Remove(_FormMaster);
            await _context.SaveChangesAsync();

            return _FormMaster;
        }

        private bool FormMasterExists(int id)
        {
            return _context.FormMaster.Any(e => e.Id == id);
        }
    }
}
