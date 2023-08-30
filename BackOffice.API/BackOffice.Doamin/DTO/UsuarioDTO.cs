using BackOffice.Doamin.Enum;
namespace BackOffice.Domain.DTO
{
    public class UsuarioDTO
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public EPerfil Perfil { get; set; }
        public string SenhaHash { get; set; }
        public bool Ativo { get; set; }
    }
}
