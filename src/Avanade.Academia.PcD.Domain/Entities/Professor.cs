namespace Avanade.Academia.PcD.Domain.Entities
{
    public class Professor : BaseEntity
    {
        public Professor(
            DateTime dataAtualizacao,
            string nome,
            decimal salario
            )
            : base( dataAtualizacao)
        {
            Nome = nome;
            Salario = salario;
        }

        public string Nome { get; set; }

        public Decimal Salario { get; set; }
    }
}
