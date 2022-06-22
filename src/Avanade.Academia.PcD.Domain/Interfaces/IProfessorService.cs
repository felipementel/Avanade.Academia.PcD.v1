using Avanade.Academia.PcD.Domain.Entities;

namespace Avanade.Academia.PcD.Domain.Interfaces
{
    public interface IProfessorService
    {
        Professor AdicionarProcessor(Professor professor);

        IEnumerable<Professor> ListarProfessores();

        Professor? ObterProfessor(Guid IdProfessor);

        Professor? AtualizarProfessor(Guid IdProfessor, Professor Professor);

        bool DeletarProfessor(Guid IdProfessor);
    }
}