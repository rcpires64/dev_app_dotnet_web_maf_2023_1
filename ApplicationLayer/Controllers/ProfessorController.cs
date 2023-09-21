using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Swagger.Annotations;

namespace ApplicationLayer.Controllers
{
    [ApiController]  //Por esta linha que o swagger monta a tela
    [Route("api/[Controller]")]
    public class ProfessorController : ControllerBase
    {

        [HttpPost]
        [SwaggerOperation("Cadastra um novo professor")]
        [SwaggerResponse(201)] //create
        [SwaggerResponse(400)] //bad request
        [SwaggerResponse(204)] //no content: http responses: https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status#respostas_bem-sucedidas
       // public ActionResult<Professor> Register(int matricula, string nome, IEnumerable<string> conhecimentos)
        public ActionResult<Professor> Register([FromBody] Professor professor)
        {
            if (professor.Conhecimentos.Count() <= 0)
            {
                return NoContent();
            }

            return Created("", professor);
        }

        [HttpPatch("{matricula}")]
        [SwaggerOperation("Atualiza um professor")]
        [SwaggerResponse(200)] //create
        [SwaggerResponse(400)] //bad request
        public ActionResult<Professor> UpdateConhecimentos([FromRoute] int matricula, [FromBody] IEnumerable<string> conhecimentos)
        {
            var prof = new Professor
            {
                Matricula = 987654,
                Nome = "Claudio Rafael",
                Conhecimentos = new List<string>
                {
                    "HTML","ASP","CSS"
                }
            };
            var prof2 = new Professor
            {
                Matricula = 21563,
                Nome = "Luis Lesssa",
                Conhecimentos = new List<string>
                {
                    "C#","Java","Phyton"
                }
            };

            if (!conhecimentos.Any())
            {
                return BadRequest();
            }
            
            if (matricula == 987654)
            {
                //var tmp = prof.Conhecimentos.ToList();
                //tmp.AddRange(conhecimentos);
                //prof.Conhecimentos = tmp;
                prof.Conhecimentos = prof.Conhecimentos.Concat(conhecimentos).ToList();
                //prof.Conhecimentos = prof.Conhecimentos.ToList().AddRange(conhecimentos);
                return Ok(prof);
            }
            //var tmp2 = prof2.Conhecimentos.ToList();
            //tmp2.AddRange(conhecimentos);
            //prof2.Conhecimentos = tmp2;
            prof2.Conhecimentos = prof2.Conhecimentos.Concat(conhecimentos).ToList();
            return Ok(prof2);
        }
    }
}
