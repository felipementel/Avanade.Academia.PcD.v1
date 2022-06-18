using Avanade.Academia.PcD.Domain.Entities;
using Avanade.Academia.PcD.Domain.Repositories;

namespace Avanade.Academia.PcD.Infra.Database.Repositories
{
    public class ProfessorRepository : IProfessorRepository
    {
        private readonly ProjetoContext _projetoContext;

        public ProfessorRepository(ProjetoContext projetoContext)
        {
            _projetoContext = projetoContext;
        }

        public Professor AtualizarProfessor(Guid IdProfessor, Professor Professor)
        {
            throw new NotImplementedException();
        }

        public void ExcluirProfessor(Guid IdProfessor)
        {
            throw new NotImplementedException();
        }

        public Professor InserirProcessor(Professor professor)
        {
            _projetoContext.Professores.Add(professor);
            _projetoContext.SaveChanges();

            return professor;
        }

        public Professor LerProfessor(Guid IdProfessor)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Professor> LerProfessores()
        {
            return _projetoContext.Professores;
        }
    }
}
