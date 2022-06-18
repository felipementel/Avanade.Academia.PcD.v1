using Avanade.Academia.PcD.Domain.Entities;

namespace Avanade.Academia.PcD.Domain.Repositories
{
    public interface IProfessorRepository
    {
        Professor InserirProcessor(Professor professor);

        IEnumerable<Professor> LerProfessores();

        Professor LerProfessor(Guid IdProfessor);

        Professor AtualizarProfessor(Guid IdProfessor, Professor Professor);

        void ExcluirProfessor(Guid IdProfessor);
    }
}
