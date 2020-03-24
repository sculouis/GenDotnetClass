
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
 

namespace MyProjectApi.Controllers
{
    [Route("api/[controller]")]
    public class ENPMasterController : ControllerBase
    {
        private readonly MyDBContext _context;


        public ENPMasterController(MyDBContext content)
        {
            _context = content;
        }

        // GET: api/ENPMaster
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ENPMaster>>> Get()
        {
            return await _context.ENPMaster.ToListAsync();
        }

        // GET: api/ENPMaster/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ENPMaster>> Get(int id)
        {
            var _ENPMaster = await _context.ENPMaster.FindAsync(id);

            if (_ENPMaster == null)
            {
                return NotFound();
            }

            return _ENPMaster;
        }

        // PUT: api/ENPMaster/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]ENPMaster _ENPMaster)
        {
            if (id != _ENPMaster.Id)
            {
                return BadRequest();
            }

            _context.Entry(_ENPMaster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ENPMasterExists(id))
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

        // POST: api/ENPMaster
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [HttpPost]
        public async Task<ActionResult<ENPMaster>> Post([FromBody]ENPMaster _ENPMaster)
        {
            _context.ENPMaster.Add(_ENPMaster);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetENPMaster", new { id = _ENPMaster.Id }, _ENPMaster);
            return CreatedAtAction(nameof(Get), new { id = _ENPMaster.Id }, _ENPMaster);
        }

        // DELETE: api/ENPMaster/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ENPMaster>> Delete(int id)
        {
            var _ENPMaster = await _context.ENPMaster.FindAsync(id);
            if (_ENPMaster == null)
            {
                return NotFound();
            }

            _context.ENPMaster.Remove(_ENPMaster);
            await _context.SaveChangesAsync();

            return _ENPMaster;
        }

        private bool ENPMasterExists(int id)
        {
            return _context.ENPMaster.Any(e => e.Id == id);
        }
    }
}
