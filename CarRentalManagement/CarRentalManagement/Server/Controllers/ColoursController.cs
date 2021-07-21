using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ColoursController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ColoursController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Colours
        [HttpGet]
        public async Task<IActionResult> GetColours()
        {
            return Ok(await _unitOfWork.Colours.GetAll());
        }

        // GET: /Colours/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetColour(int id)
        {
            Colour colour = await _unitOfWork.Colours.Get(q => q.Id == id);

            if (colour == null)
            {
                return NotFound();
            }

            return Ok(colour);
        }

        // POST: api/Colours
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Make>> PostColour(Colour colour)
        {
            await _unitOfWork.Colours.Insert(colour);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetColour", new { id = colour.Id }, colour);
        }

        // DELETE: api/Colours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColour(int id)
        {
            Colour colour = await _unitOfWork.Colours.Get(q => q.Id == id);
            if (colour == null)
            {
                return NotFound();
            }
            await _unitOfWork.Colours.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ColourExists(int id)
        {
            var Colour = await _unitOfWork.Colours.Get(q => q.Id == id);
            return Colour == null;
        }
    }
}
