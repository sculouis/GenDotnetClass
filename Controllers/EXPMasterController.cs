
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
 

namespace MyWeb.Controllers
{
    [Route("api/[controller]")]
    public class EXPMasterController : ControllerBase
    {
        private readonly MyDBContext _context;


        public EXPMasterController(MyDBContext content)
        {
            _context = content;
        }

        // GET: api/EXPMaster
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EXPMaster>>> Get()
        {
            return await _context.EXPMaster.ToListAsync();
        }

        // GET: api/EXPMaster/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EXPMaster>> Get(int id)
        {
            var _EXPMaster = await _context.EXPMaster.FindAsync(id);

            if (_EXPMaster == null)
            {
                return NotFound();
            }

            return _EXPMaster;
        }

        // PUT: api/EXPMaster/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]EXPMaster _EXPMaster)
        {
            if (id != _EXPMaster.Id)
            {
                return BadRequest();
            }

            _context.Entry(_EXPMaster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EXPMasterExists(id))
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

        // POST: api/EXPMaster
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [HttpPost]
        public async Task<ActionResult<EXPMaster>> Post([FromBody]EXPMaster _EXPMaster)
        {
            _context.EXPMaster.Add(_EXPMaster);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetEXPMaster", new { id = _EXPMaster.Id }, _EXPMaster);
            return CreatedAtAction(nameof(Get), new { id = _EXPMaster.Id }, _EXPMaster);
        }

        // DELETE: api/EXPMaster/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EXPMaster>> Delete(int id)
        {
            var _EXPMaster = await _context.EXPMaster.FindAsync(id);
            if (_EXPMaster == null)
            {
                return NotFound();
            }

            _context.EXPMaster.Remove(_EXPMaster);
            await _context.SaveChangesAsync();

            return _EXPMaster;
        }

        private bool EXPMasterExists(int id)
        {
            return _context.EXPMaster.Any(e => e.Id == id);
        }
    }
}
