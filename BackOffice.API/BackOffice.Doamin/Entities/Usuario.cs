using BackOffice.Doamin.Enum;

namespace BackOffice.Doamin.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public EPerfil Perfil { get; set; }
        public string SenhaHash { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
