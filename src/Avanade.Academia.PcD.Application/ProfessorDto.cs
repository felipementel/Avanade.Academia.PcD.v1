using Avanade.Academia.PcD.Domain.Entities;

namespace Avanade.Academia.PcD.Application
{
    public class ProfessorDto
    {
        public ProfessorDto(
            Guid idProfessor,
            string nome,
            decimal salario,
            DateTime dataCriacao,
            DateTime dataAtualizacao)
        {
            IdProfessor = idProfessor;
            Nome = nome;
            Salario = salario;
            DataCriacao = dataCriacao;
            DataAtualizacao = dataAtualizacao;
        }

        public Guid IdProfessor { get; set; }

        public string Nome { get; set; }

        public decimal Salario { get; set; }

        public DateTime DataCriacao { get; private set; }

        public DateTime DataAtualizacao { get; private set; }

        public static implicit operator Professor(ProfessorDto professorDto) =>
            new(professorDto.DataAtualizacao,
                professorDto.Nome,
                professorDto.Salario);

        public static implicit operator ProfessorDto(Professor professor) =>
            new(professor.Id,
                professor.Nome,
                professor.Salario,
                professor.DataCriacao,
                professor.DataAtualizacao);
    }
}