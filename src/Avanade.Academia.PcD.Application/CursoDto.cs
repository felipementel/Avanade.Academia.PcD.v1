using Avanade.Academia.PcD.Domain.Entities;

namespace Avanade.Academia.PcD.Application
{
    public class CursoDto
    {
        public CursoDto(
            Guid idCurso,
            string nome, 
            string descricao,
            Guid idProfessor, 
            ProfessorDto professorDto,
            DateTime dataCriacao, 
            DateTime dataAtualizacao)
        {
            IdCurso = idCurso;
            Nome = nome;
            Descricao = descricao;
            IdProfessor = idProfessor;
            ProfessorDto = professorDto;
            DataCriacao = dataCriacao;
            DataAtualizacao = dataAtualizacao;
        }

        public Guid IdCurso { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public Guid IdProfessor { get; set; }

        public ProfessorDto ProfessorDto { get; set; }

        public DateTime DataCriacao { get; private set; }

        public DateTime DataAtualizacao { get; private set; }

        public static implicit operator Curso(CursoDto cursoDto) =>
            new(
                cursoDto.DataAtualizacao,
                cursoDto.Nome,
                cursoDto.Descricao);

        public static implicit operator CursoDto(Curso curso) =>
            new(curso.Id,
                curso.Nome,
                curso.Descricao,
                curso.IdProfessor,
                professorDto: curso.Professor,
                curso.DataCriacao,
                curso.DataAtualizacao);
    }
}