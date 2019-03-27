using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuotesAPI.Models;

namespace QuotesAPI.Controllers
{
    [Route("api/quotes")]
    [ApiController]
    public class QuotesModelsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly QuotesModel RandomQuote;

        public QuotesModelsController(ApplicationDbContext context)
        {
            _context = context;
            RandomQuote = _context.QuotesModel.OrderBy(quote => Guid.NewGuid()).FirstOrDefault();
        }

        [Route("QOTD")]
        public ActionResult<QuotesModel> GetRandomQuote()
        {
            
            return Ok(RandomQuote);
        }

        // GET: api/QuotesModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuotesModel>>> GetQuotesModel()
        {
            return await _context.QuotesModel.ToListAsync();
        }

        // GET: api/QuotesModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<QuotesModel>> GetQuotesModel(int id)
        {
            var quotesModel = await _context.QuotesModel.FindAsync(id);

            if (quotesModel == null)
            {
                return NotFound();
            }

            return quotesModel;
        }

        // PUT: api/QuotesModels/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuotesModel(int id, QuotesModel quotesModel)
        {
            if (id != quotesModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(quotesModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuotesModelExists(id))
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

        // POST: api/QuotesModels
        [HttpPost]
        public async Task<ActionResult<QuotesModel>> PostQuotesModel(QuotesModel quotesModel)
        {
            _context.QuotesModel.Add(quotesModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuotesModel", new { id = quotesModel.Id }, quotesModel);
        }

        // DELETE: api/QuotesModels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<QuotesModel>> DeleteQuotesModel(int id)
        {
            var quotesModel = await _context.QuotesModel.FindAsync(id);
            if (quotesModel == null)
            {
                return NotFound();
            }

            _context.QuotesModel.Remove(quotesModel);
            await _context.SaveChangesAsync();

            return quotesModel;
        }

        private bool QuotesModelExists(int id)
        {
            return _context.QuotesModel.Any(e => e.Id == id);
        }
    }
}
