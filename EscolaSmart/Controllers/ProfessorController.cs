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
        private readonly IRepository _repo;

        public ProfessorController(DataContext context, IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _repo.GetAllProfessores(true);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var professor = _repo.GetAllProfessorById(id, false);
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
            var p = _repo.GetAllProfessorById(id, false);

            if (p == null)
            {
                return BadRequest("Professor não encontrado");
            }

            _repo.Update(professor);
            if (_repo.SaveChanges())
            {
                return Ok(professor);
            }

            return BadRequest("Professor não atualizado");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Professor professor)
        {
            var p = _repo.GetAllProfessorById(id, false);

            if (p == null)
            {
                return BadRequest("Professor não encontrado");
            }

            _repo.Update(professor);
            if (_repo.SaveChanges())
            {
                return Ok(professor);
            }

            return BadRequest("Professor não atualizado");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var professor = _repo.GetAllProfessorById(id, false);

            if (professor == null)
            {
                return BadRequest("Professor não encontrado");
            }

            _repo.Update(professor);
            if (_repo.SaveChanges())
            {
                return Ok(professor);
            }

            return BadRequest("Professor não deletado");
        }
    }
}
