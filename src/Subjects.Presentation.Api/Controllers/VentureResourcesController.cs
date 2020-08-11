﻿using GoodToCode.Subjects.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodToCode.Subjects.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentureResourcesController : ControllerBase
    {
        private readonly SubjectsDbContext _context;

        public VentureResourcesController(SubjectsDbContext context)
        {
            _context = context;
        }

        // GET: api/VentureResources
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VentureResource>>> GetVentureResource()
        {
            return await _context.VentureResource.ToListAsync();
        }

        // GET: api/VentureResources/5
        [HttpGet("{key}")]
        public async Task<ActionResult<VentureResource>> GetVentureResource(Guid key)
        {
            var ventureResource = await _context.VentureResource.FindAsync(key);

            if (ventureResource == null)
            {
                return NotFound();
            }

            return ventureResource;
        }

        // PUT: api/VentureResources/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{key}")]
        public async Task<IActionResult> PutVentureResource(Guid key, VentureResource ventureResource)
        {
            if (key != ventureResource.VentureResourceKey)
            {
                return BadRequest();
            }

            _context.Entry(ventureResource).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VentureResourceExists(key))
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

        // POST: api/VentureResources
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<VentureResource>> PostVentureResource(VentureResource ventureResource)
        {
            _context.VentureResource.Add(ventureResource);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVentureResource", new { key = ventureResource.VentureResourceKey }, ventureResource);
        }

        // DELETE: api/VentureResources/5
        [HttpDelete("{key}")]
        public async Task<ActionResult<VentureResource>> DeleteVentureResource(Guid key)
        {
            var ventureResource = await _context.VentureResource.FindAsync(key);
            if (ventureResource == null)
            {
                return NotFound();
            }

            _context.VentureResource.Remove(ventureResource);
            await _context.SaveChangesAsync();

            return ventureResource;
        }

        private bool VentureResourceExists(Guid key)
        {
            return _context.VentureResource.Any(e => e.VentureResourceKey == key);
        }
    }
}
