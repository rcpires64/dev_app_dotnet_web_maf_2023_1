using Microsoft.AspNetCore.Mvc;

namespace ApplicationLayer.Controllers
{
    [ApiController]  //Por esta linha que o swagger monta a tela
    [Route("aluno")]
    public class AlunoController : ControllerBase
    {
        private static readonly string[] Alunos = new[]
        {
            "João",
            "Manoel",
            "Bianca",
            "Carla",
            "Alfredo",
            "Melissa",
            "Cláudio",
            "Pamela",
            "Bernardo",
            "Ana"
    };

        private readonly ILogger<AlunoController> _logger;

        public AlunoController(ILogger<AlunoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<Aluno> Get()
        {
            var aluno = new Aluno
            {
                Matricula = 12345,
                Nome = "Luis",
                DataNascimento = new DateOnly(1987, 4, 29)
            };
            return Ok(aluno);  //o Ok retorna header http
        }
    }
}