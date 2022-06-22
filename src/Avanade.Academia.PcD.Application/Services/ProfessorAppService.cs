using Avanade.Academia.PcD.Application.Dtos;
using Avanade.Academia.PcD.Application.Interfaces;
using Avanade.Academia.PcD.Domain.Interfaces;

namespace Avanade.Academia.PcD.Application.Services
{
    public class ProfessorAppService : IProfessorAppService
    {
        private readonly IProfessorService _professorService;

        public ProfessorAppService(IProfessorService professorService)
        {
            _professorService = professorService;
        }

        public ProfessorDto AdicionarProcessor(ProfessorDto professorDto)
        {
            return _professorService.AdicionarProcessor(professorDto);
        }

        public ProfessorDto AtualizarProfessor(Guid IdProfessor, ProfessorDto ProfessorDto)
        {
            return _professorService.AtualizarProfessor(IdProfessor, ProfessorDto);
        }

        public bool DeletarProfessor(Guid IdProfessor)
        {
            return _professorService.DeletarProfessor(IdProfessor);
        }

        public IEnumerable<ProfessorDto> ListarProfessores()
        {
            var items = _professorService.ListarProfessores();

            return items.Select(p => new ProfessorDto(
                p.Id,
                p.Nome,
                p.Salario,
                p.DataCriacao,
                p.DataAtualizacao));
        }

        public ProfessorDto ObterProfessor(Guid IdProfessor)
        {
            return _professorService.ObterProfessor(IdProfessor);
        }
    }
}
