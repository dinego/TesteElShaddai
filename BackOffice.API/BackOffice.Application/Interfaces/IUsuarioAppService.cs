using BackOffice.Doamin.Entities;
using BackOffice.Domain.DTO;

namespace BackOffice.Application.Interfaces
{
    public interface IUsuarioAppService
    {
        UsuarioDTO Get(string usuarioId);
        IEnumerable<UsuarioDTO> GetAll();
        void Create(UsuarioDTO usuario);
        void Update(UsuarioDTO usuario);
        void Delete(string usuarioId);
    }
}
