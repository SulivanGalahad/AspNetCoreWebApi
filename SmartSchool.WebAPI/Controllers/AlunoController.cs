using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;
using System.Linq;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {

        public List<Aluno> listaAlunos = new List<Aluno>(){
            new Aluno(){Id = 1, Nome = "Jerifona", Sobrenome = "Caliperson", Telefone = "56465465465"},
            new Aluno(){Id = 2, Nome = "Larisberto", Sobrenome = "Xelopintro", Telefone = "98798798789"},
            new Aluno(){Id = 3, Nome = "Claudistirno", Sobrenome = "Freximontuin", Telefone = "54654987846"}
        };
        public AlunoController(){}

       [HttpGet]
        public IActionResult Get()
        {
            return Ok(listaAlunos);
        }

        // http://localhost:5000/api/aluno/1 
         [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var aluno = listaAlunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null)
            {
                return BadRequest("Nunca nem vi!");
            }
            return Ok(aluno);
        }

       /*  [HttpGet("byId")]  or [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = listaAlunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null)
            {
                return BadRequest("Nunca nem vi!");
            }
            return Ok(aluno);
        } */

        // http://localhost:5000/api/aluno/is
       /*    [HttpGet("{nome}")]
        public IActionResult GetByName(string nome)
        {
            var aluno = listaAlunos.FirstOrDefault(a => a.Nome.Contains(nome));
            if (aluno == null)
            {
                return BadRequest("Nunca nem vi!");
            }
            return Ok(aluno);
        } */


         // http://localhost:5000/api/aluno/Byname?nome=ri&sobrenome=ipe
          [HttpGet("ByName")]
        public IActionResult GetByName(string nome, string sobreNome)
        {
            var aluno = listaAlunos.FirstOrDefault(a => a.Nome.Contains(nome) ||
                                                        a.Nome.Contains(sobreNome));

            if (aluno == null)
            {
                return BadRequest("Nunca nem vi!");
            }
            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
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