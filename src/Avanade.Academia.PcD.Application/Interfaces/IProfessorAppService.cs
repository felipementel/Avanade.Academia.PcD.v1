namespace Avanade.Academia.PcD.Application.Interfaces
{
    public interface IProfessorAppService
    {
        ProfessorDto AdicionarProcessor(ProfessorDto professorDto);

        IEnumerable<ProfessorDto> ListarProfessores();

        ProfessorDto ObterProfessor(Guid IdProfessor);

        ProfessorDto AtualizarProfessor(Guid IdProfessor, ProfessorDto ProfessorDto);

        void DeletarProfessor(Guid IdProfessor);
    }
}