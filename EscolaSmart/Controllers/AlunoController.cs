using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscolaSmart.Models;
using EscolaSmart.Data;
using Microsoft.EntityFrameworkCore;

namespace EscolaSmart.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class AlunoController : ControllerBase
    {
        public readonly IRepository _repo;

        public AlunoController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _repo.GetAllAlunos(true);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = _repo.GetAllAlunoById(id, false);
            if (aluno == null) return BadRequest("O Aluno não foi encontrado");

            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            _repo.Add(aluno);
            if (_repo.SaveChanges())
            {
                return Ok(aluno);
            }

            return BadRequest("Aluno não cadastrado");

        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,Aluno aluno)
        {
            var alu = _repo.GetAllAlunoById(id);

            if (alu == null)
            {
                return BadRequest("Aluno não encontrado");
            }

            _repo.Update(aluno);
            if (_repo.SaveChanges())
            {
                return Ok(aluno);
            }

            return BadRequest("Aluno não cadastrado");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            var a = _repo.GetAllAlunoById(id);

            if (a == null)
            {
                return BadRequest("Aluno não encontrado");
            }

            _repo.Update(aluno);
            if (_repo.SaveChanges())
            {
                return Ok(aluno);
            }

            return BadRequest("Aluno não cadastrado");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var aluno = _repo.GetAllAlunoById(id);

            if (aluno == null)
            {
                return BadRequest("Aluno não encontrado");
            }

            _repo.Delete(aluno);
            if (_repo.SaveChanges())
            {
                return Ok("Aluno deletado");
            }

            return BadRequest("Aluno não deletado");
        }
    }
}
