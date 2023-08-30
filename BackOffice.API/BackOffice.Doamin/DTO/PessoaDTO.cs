using BackOffice.Doamin.Enum;
using BackOffice.Domain.Entities;

namespace BackOffice.Domain.DTO
{
    public class PessoaDTO
    {
        public ETipoPessoa TipoPessoa { get; set; }
        public string Documento { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public Endereco Endereco { get; set; }
        public List<PessoaQualificacao> PessoasQualificacoes { get; set; } = new List<PessoaQualificacao>();
    }
}
