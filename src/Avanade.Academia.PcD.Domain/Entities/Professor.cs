using static Avanade.Academia.PcD.Domain.ValueObject.Enumerators;

namespace Avanade.Academia.PcD.Domain.Entities
{
    public class Professor : BaseEntity
    {
        public Professor(
            DateTime dataAtualizacao,
            string nome,
            decimal salario,
            Periodo periodo
            )
            : base(dataAtualizacao)
        {
            Nome = nome;
            Salario = salario;
            Periodo = periodo;
        }

        public string Nome { get; set; }

        public Decimal Salario { get; set; }

        public Periodo Periodo { get; set; }
    }
}