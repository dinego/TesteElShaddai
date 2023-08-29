using BackOffice.Doamin.Enum;

namespace BackOffice.Doamin.Entities
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public ETipoPessoa TipoPessoa { get; set; }
        public string Documento { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Endereco { get; set; }
        public List<EQualificacao> Qualificacoes { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
