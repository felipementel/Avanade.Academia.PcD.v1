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

        public Professor AtualizarProfessor(Professor Professor)
        {
            Professor.DataAtualizacao = DateTime.Now;

            _projetoContext.Professores.Update(Professor);            
            _projetoContext.SaveChanges();

            return Professor;
        }

        public bool ExcluirProfessor(Guid IdProfessor)
        {
            var prof = _projetoContext.Professores.FirstOrDefault(p => p.Id == IdProfessor);

            if (prof is not null)
            {
                _projetoContext.Professores.Remove(prof);
                return _projetoContext.SaveChanges() == 1 ? true : false;
            }

            return false;
        }

        public Professor InserirProcessor(Professor professor)
        {
            _projetoContext.Professores.Add(professor);
            _projetoContext.SaveChanges();

            return professor;
        }

        public Professor? LerProfessor(Guid IdProfessor)
        {
            return _projetoContext.Professores.FirstOrDefault(p => p.Id == IdProfessor);
        }

        public IEnumerable<Professor> LerProfessores()
        {
            return _projetoContext.Professores;
        }
    }
}
