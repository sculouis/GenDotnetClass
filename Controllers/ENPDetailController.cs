
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
 

namespace MyProjectApi.Controllers
{
    [Route("api/[controller]")]
    public class ENPDetailController : ControllerBase
    {
        private readonly MyDBContext _context;


        public ENPDetailController(MyDBContext content)
        {
            _context = content;
        }

        // GET: api/ENPDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ENPDetail>>> Get()
        {
            return await _context.ENPDetail.ToListAsync();
        }

        // GET: api/ENPDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ENPDetail>> Get(int id)
        {
            var _ENPDetail = await _context.ENPDetail.FindAsync(id);

            if (_ENPDetail == null)
            {
                return NotFound();
            }

            return _ENPDetail;
        }

        // PUT: api/ENPDetail/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]ENPDetail _ENPDetail)
        {
            if (id != _ENPDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(_ENPDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ENPDetailExists(id))
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

        // POST: api/ENPDetail
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [HttpPost]
        public async Task<ActionResult<ENPDetail>> Post([FromBody]ENPDetail _ENPDetail)
        {
            _context.ENPDetail.Add(_ENPDetail);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetENPDetail", new { id = _ENPDetail.Id }, _ENPDetail);
            return CreatedAtAction(nameof(Get), new { id = _ENPDetail.Id }, _ENPDetail);
        }

        // DELETE: api/ENPDetail/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ENPDetail>> Delete(int id)
        {
            var _ENPDetail = await _context.ENPDetail.FindAsync(id);
            if (_ENPDetail == null)
            {
                return NotFound();
            }

            _context.ENPDetail.Remove(_ENPDetail);
            await _context.SaveChangesAsync();

            return _ENPDetail;
        }

        private bool ENPDetailExists(int id)
        {
            return _context.ENPDetail.Any(e => e.Id == id);
        }
    }
}
