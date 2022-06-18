using Avanade.Academia.PcD.Domain.Entities;
using Avanade.Academia.PcD.Domain.Interfaces;
using Avanade.Academia.PcD.Domain.Repositories;

namespace Avanade.Academia.PcD.Application.Services
{
    public class ProfessorService : IProfessorService
    {
        private readonly IProfessorRepository _professorRepository;

        public ProfessorService(
            IProfessorRepository professorRepository)
        {
            _professorRepository = professorRepository;
        }

        public Professor AdicionarProcessor(Professor professor)
        {
            return _professorRepository.InserirProcessor(professor);
        }

        public Professor AtualizarProfessor(Guid IdProfessor, Professor ProfessorDto)
        {
            return _professorRepository.AtualizarProfessor(IdProfessor, ProfessorDto);
        }

        public void DeletarProfessor(Guid IdProfessor)
        {
            _professorRepository.ExcluirProfessor(IdProfessor);
        }

        public IEnumerable<Professor> ListarProfessores()
        {
            return _professorRepository.LerProfessores();
        }

        public Professor ObterProfessor(Guid IdProfessor)
        {
            return _professorRepository.LerProfessor(IdProfessor);
        }
    }
}
