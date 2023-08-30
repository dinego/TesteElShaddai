using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackOffice.Doamin.Entities
{
    [Table("Departamento")]
    public class Departamento
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Pessoa Responsavel { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
