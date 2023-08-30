using BackOffice.Doamin.Enum;
using BackOffice.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackOffice.Doamin.Entities
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Key]
        public Guid Id { get; set; }
        public ETipoPessoa TipoPessoa { get; set; }
        public string Documento { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public List<Endereco> Enderecos { get; set; } = new List<Endereco>();
        public List<PessoaQualificacao> PessoasQualificacoes { get; set; } = new List<PessoaQualificacao>();
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
