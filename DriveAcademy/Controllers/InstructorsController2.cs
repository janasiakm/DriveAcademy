﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DriveAcademyApi.Models;

namespace DriveAcademyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController2 : ControllerBase
    {
        private readonly DriveAcademyDbContext _context;

        public InstructorsController2(DriveAcademyDbContext context)
        {
            _context = context;
        }

        // GET: api/InstructorsController2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Instructor>>> GetInstructors()
        {
          if (_context.Instructors == null)
          {
              return NotFound();
          }
            return await _context.Instructors.ToListAsync();
        }

        // GET: api/InstructorsController2/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Instructor>> GetInstructor(int id)
        {
          if (_context.Instructors == null)
          {
              return NotFound();
          }
            var instructor = await _context.Instructors.FindAsync(id);

            if (instructor == null)
            {
                return NotFound();
            }

            return instructor;
        }

        // PUT: api/InstructorsController2/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInstructor(int id, Instructor instructor)
        {
            if (id != instructor.Id)
            {
                return BadRequest();
            }

            _context.Entry(instructor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstructorExists(id))
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

        // POST: api/InstructorsController2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Instructor>> PostInstructor(Instructor instructor)
        {
          if (_context.Instructors == null)
          {
              return Problem("Entity set 'DriveAcademyDbContext.Instructors'  is null.");
          }
            _context.Instructors.Add(instructor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInstructor", new { id = instructor.Id }, instructor);
        }

        // DELETE: api/InstructorsController2/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInstructor(int id)
        {
            if (_context.Instructors == null)
            {
                return NotFound();
            }
            var instructor = await _context.Instructors.FindAsync(id);
            if (instructor == null)
            {
                return NotFound();
            }

            _context.Instructors.Remove(instructor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InstructorExists(int id)
        {
            return (_context.Instructors?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}