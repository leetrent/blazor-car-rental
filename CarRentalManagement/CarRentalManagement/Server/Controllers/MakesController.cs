﻿using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MakesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public MakesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Makes
        [HttpGet]
        public async Task<IActionResult> GetMakes()
        {
            IList<Make> makes = await _unitOfWork.Makes.GetAll();

            if (makes == null || makes.Count < 1)
            {
                return NotFound();
            }

            return Ok(makes);
        }

        // GET: api/Makes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMake(int id)
        {
            Make make = await _unitOfWork.Makes.Get(q => q.Id == id);

            if (make == null)
            {
                return NotFound();
            }

            return Ok(make);
        }

        // POST: api/Makes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Make>> PostMake(Make make)
        {
            await _unitOfWork.Makes.Insert(make);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetMake", new { id = make.Id }, make);
        }

        // DELETE: api/Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMake(int id)
        {
            var make = await _unitOfWork.Makes.Get(q => q.Id == id);
            if (make == null)
            {
                return NotFound();
            }

            await _unitOfWork.Makes.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        // PUT: api/Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutMake(int id, Make make)
        //{
        //    if (id != make.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _unitOfWork.Makes.Update(make);

        //    try
        //    {
        //        await _unitOfWork.Save(HttpContext);
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!await MakeExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //private async Task<bool> MakeExists(int id)
        //{
        //    var make = await _unitOfWork.Makes.Get(q => q.Id == id);
        //    return make != null;
        //}
    }
}
