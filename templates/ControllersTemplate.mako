<%namespace file="UsingControllersTemplate.mako" import="*"/>\
${using()} 
<%
    tableName = '_' + TableName
%>
namespace MyWeb.Controllers
{
    [Route("api/[controller]")]
    public class ${TableName}Controller : ControllerBase
    {
        private readonly MyDBContext _context;


        public ${TableName}Controller(MyDBContext content)
        {
            _context = content;
        }

        // GET: api/${TableName}
        [HttpGet]
        public async Task<ActionResult<IEnumerable<${TableName}>>> Get()
        {
            return await _context.${TableName}.ToListAsync();
        }

        // GET: api/${TableName}/5
        [HttpGet("{id}")]
        public async Task<ActionResult<${TableName}>> Get(int id)
        {
            var ${tableName} = await _context.${TableName}.FindAsync(id);

            if (${tableName} == null)
            {
                return NotFound();
            }

            return ${tableName};
        }

        // PUT: api/${TableName}/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]${TableName} ${tableName})
        {
            if (id != ${tableName}.Id)
            {
                return BadRequest();
            }

            _context.Entry(${tableName}).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!${TableName}Exists(id))
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

        // POST: api/${TableName}
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [HttpPost]
        public async Task<ActionResult<${TableName}>> Post([FromBody]${TableName} ${tableName})
        {
            _context.${TableName}.Add(${tableName});
            await _context.SaveChangesAsync();

            //return CreatedAtAction("Get${TableName}", new { id = ${tableName}.Id }, ${tableName});
            return CreatedAtAction(nameof(Get), new { id = ${tableName}.Id }, ${tableName});
        }

        // DELETE: api/${TableName}/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<${TableName}>> Delete(int id)
        {
            var ${tableName} = await _context.${TableName}.FindAsync(id);
            if (${tableName} == null)
            {
                return NotFound();
            }

            _context.${TableName}.Remove(${tableName});
            await _context.SaveChangesAsync();

            return ${tableName};
        }

        private bool ${TableName}Exists(int id)
        {
            return _context.${TableName}.Any(e => e.Id == id);
        }
    }
}
