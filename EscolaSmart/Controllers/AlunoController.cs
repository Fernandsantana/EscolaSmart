using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscolaSmart.Models;

namespace EscolaSmart.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>()
        {
            new Aluno()
            {
                Id = 1,
                Nome = "Malu",
                Sobrenome = "Santana",
                Telefone = "123456"
            },

            new Aluno()
            {
                Id = 2,
                Nome = "Jhordan",
                Sobrenome = "Santana",
                Telefone = "654321"
            },
        };

        public AlunoController() {}

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("O Aluno não foi encontrado");

            return Ok(aluno);
        }

        [HttpGet("byName")]
        public IActionResult GetByName(string nome, string Sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Nome.Contains(nome) && a.Sobrenome.Contains(Sobrenome));
            if (aluno == null) return BadRequest("O Aluno não foi encontrado");

            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
