using BackOffice.Doamin.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackOffice.Domain.Entities
{
    [Table("Endereco")]
    public class Endereco
    {
        public Guid Id { get; set; }
        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string IBGE { get; set; }

        // Referência à Pessoa
        [ForeignKey("Pessoa")]
        public Guid PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
