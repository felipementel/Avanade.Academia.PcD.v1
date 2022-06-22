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

        public Professor? AtualizarProfessor(Guid IdProfessor, Professor Professor)
        {
            var prof = _professorRepository.LerProfessor(IdProfessor);

            if (prof != null)
            {
                prof.Nome = Professor.Nome != String.Empty ? Professor.Nome : prof.Nome;
                prof.Salario = Professor.Salario != 0 ? Professor.Salario : prof.Salario;
                prof.Periodo = Professor.Periodo != 0 ? Professor.Periodo : prof.Periodo;

                return _professorRepository.AtualizarProfessor(Professor);
            }

            return prof;            
        }

        public bool DeletarProfessor(Guid IdProfessor)
        {
            return _professorRepository.ExcluirProfessor(IdProfessor);
        }

        public IEnumerable<Professor> ListarProfessores()
        {
            return _professorRepository.LerProfessores();
        }

        public Professor? ObterProfessor(Guid IdProfessor)
        {
            return _professorRepository.LerProfessor(IdProfessor);
        }
    }
}
