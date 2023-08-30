using BackOffice.Doamin.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackOffice.Domain.Entities
{
    [Table("Qualificacao")]
    public class Qualificacao
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }

        public List<PessoaQualificacao> PessoasQualificacoes { get; set; } = new List<PessoaQualificacao>();
    }
}
