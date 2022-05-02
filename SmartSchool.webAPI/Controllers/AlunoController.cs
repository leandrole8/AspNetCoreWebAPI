using Microsoft.AspNetCore.Mvc;
using SmartSchool.webAPI.Models;

namespace SmartSchool.webAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>(){
            new Aluno(){
                Id = 1,
                Nome = "Jose",
                Sobrenome = "Antunes",
                Telefone = "3458558578"
            },
            new Aluno(){
                Id = 2,
                Nome = "Lucia",
                Sobrenome = "Silveira",
                Telefone = "1156858578"
            },
            new Aluno(){
                Id = 3,
                Nome = "Romero",
                Sobrenome = "Borges",
                Telefone = "215686465868"
            }
        };
        public AlunoController(){}

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }
        
        [HttpGet("ById/{id}")]
        public IActionResult GetById(int Id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == Id);
            if(aluno == null) return BadRequest("ALUNO NÃO ENCONTRADO!!!");

            return Ok(aluno);
        }

        [HttpGet("ByName")]
         public IActionResult GetByName(string Nome, string Sobrenome){
             var aluno = Alunos.FirstOrDefault(a => a.Nome.Contains(Nome) && a.Sobrenome.Contains(Sobrenome));
             if(aluno == null) return BadRequest("ALUNO NÃO ENCONTRADO!!!");

             return Ok(aluno);
         }

         [HttpPost]
         public IActionResult Post(Aluno aluno){

             return Ok(aluno);
         }

         [HttpPut("{id}")]
         public IActionResult Put(int id, Aluno aluno){

             return Ok(aluno);
         }

         [HttpDelete("{id}")]
         public IActionResult Delete(int id){

             return Ok();
         }
    }
}