using EscolaSmart.Data;
using EscolaSmart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EscolaSmart.Controllers
{
    [ApiController]
    [Route("api/[controller]")]  
    
    public class ProfessorController : ControllerBase
    {
        private readonly DataContext _context;

        private readonly IRepository _repo;

        public ProfessorController(DataContext context, IRepository repo)
        {
            _context = context;
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Professores);
        }

        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var professor = _context.Professores.FirstOrDefault(p => p.Id == id);
            if (professor == null) return BadRequest("O Professor não foi encontrado");

            return Ok(professor);
        }

        [HttpGet("byName")]
        public IActionResult GetByName(string nome)
        {
            var professor = _context.Professores.FirstOrDefault(p => p.Nome.Contains(nome));
            if (professor == null) return BadRequest("O Professor não foi encontrado");

            return Ok(professor);
        }

        [HttpPost]
        public IActionResult Post(Professor professor)
        {
            _repo.Add(professor);
            if (_repo.SaveChanges())
            {
                return Ok(professor);
            }

            return BadRequest("Professor não cadastrado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Professor professor)
        {
            var prof = _context.Professores.AsNoTracking().FirstOrDefault(p => p.Id == id);

            if (prof == null)
            {
                return BadRequest("Professor não encontrado");
            }

            _context.Update(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Professor professor)
        {
            var prof = _context.Professores.AsNoTracking().FirstOrDefault(p => p.Id == id);

            if (prof == null)
            {
                return BadRequest("Professor não encontrado");
            }

            _context.Update(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var professor = _context.Professores.FirstOrDefault(p => p.Id == id);

            if (professor == null)
            {
                return BadRequest("Professor não encontrado");
            }

            _context.Remove(professor);
            _context.SaveChanges();
            return Ok();
        }
    }
}
