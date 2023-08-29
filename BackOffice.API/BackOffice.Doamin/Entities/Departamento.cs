namespace BackOffice.Doamin.Entities
{
    public class Departamento
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Pessoa Responsavel { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
