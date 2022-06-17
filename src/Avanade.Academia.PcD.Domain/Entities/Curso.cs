namespace Avanade.Academia.PcD.Domain.Entities
{
    public class Curso : BaseEntity
    {
        public Curso(
            DateTime dataAtualizacao,
            string nome,
            string descricao) : base(dataAtualizacao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public Guid IdProfessor { get; set; }

        public Professor Professor { get; set; }
    }
}