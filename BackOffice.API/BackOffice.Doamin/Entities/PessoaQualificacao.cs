using BackOffice.Doamin.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackOffice.Domain.Entities
{
    [Table("PessoaQualificacao")]
    public class PessoaQualificacao
    {
        [Key]
        public Guid PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

        [Key]
        public Guid QualificacaoId { get; set; }
        public Qualificacao Qualificacao { get; set; }
    }
}
