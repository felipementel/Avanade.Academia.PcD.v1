using Avanade.Academia.PcD.Application.Dtos;
using Avanade.Academia.PcD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Avanade.Academia.PcD.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessoresController : ControllerBase
    {
        private readonly ILogger<ProfessoresController> _logger;
        private readonly IProfessorAppService _professorAppService;

        public ProfessoresController(
            ILogger<ProfessoresController> logger,
            IProfessorAppService professorAppService)
        {
            _logger = logger;
            _professorAppService = professorAppService;
        }

        [HttpGet]
        public IActionResult ListarProfessores()
        {
            var items = _professorAppService.ListarProfessores();

            if (items.Count() > 0)
                return Ok(items);
            else
                return NotFound();
        }

        [HttpGet("{IdProfessor}")]
        public IActionResult ObterProfessor(string IdProfessor)
        {
            try
            {
                var IdentificadorProfessor = ProcessarIdProcessor(IdProfessor);
                var items = _professorAppService.ObterProfessor(IdProfessor: IdentificadorProfessor);

                return (items != null) ? Ok(items) : NotFound();
            }
            catch (ApplicationException ex)
            {
                return BadRequest("Erro gerenciado:" + ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro genérico: {ex.Message}");
            }
        }

        [HttpPost]
        public IActionResult AdicionarProfessores([FromBody] ProfessorDto professorDto)
        {
            var professorAdicionado = _professorAppService.AdicionarProcessor(professorDto);

            return CreatedAtAction(
                nameof(ObterProfessor),
                new { IdProfessor = professorAdicionado.IdProfessor },
                professorAdicionado);
        }

        [HttpPut]
        public IActionResult AtualizarProfessores(
            string IdProfessor,
            [FromBody] ProfessorDto professorDto)
        {
            try
            {
                var IdentificadorProfessor = ProcessarIdProcessor(IdProfessor);
                var professorAtualizado = _professorAppService.AtualizarProfessor(IdentificadorProfessor, professorDto);

                return Ok($"Professor id {professorAtualizado.IdProfessor} atualizado com sucesso.");
            }
            catch (ApplicationException ex)
            {
                return BadRequest("Erro gerenciado:" + ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro genérico: {ex.Message}");
            }
        }

        [HttpDelete("{IdProfessor}")]
        public IActionResult DeletarProfessores(string IdProfessor)
        {
            try
            {
                var IdentificadorProfessor = ProcessarIdProcessor(IdProfessor);
                _professorAppService.DeletarProfessor(IdentificadorProfessor);

                return NoContent();
            }
            catch (ApplicationException ex)
            {
                return BadRequest("Erro gerenciado:" + ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro genérico: {ex.Message}");
            }
        }

        private Guid ProcessarIdProcessor(string IdProfessor)
        {
            Guid IdentificadorProfessor;
            if (Guid.TryParse(IdProfessor, out IdentificadorProfessor) == false)
                throw new ApplicationException("Id do professor com problema");
            else
                return IdentificadorProfessor;
        }
    }
}