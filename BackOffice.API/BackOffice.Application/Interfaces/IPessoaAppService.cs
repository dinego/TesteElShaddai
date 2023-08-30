using BackOffice.Domain.DTO;
namespace BackOffice.Application.Interfaces
{
    public interface IPessoaAppService
    {
        Task<PessoaDTO> GetByIdAsync(Guid pessoaId);
        Task<IEnumerable<PessoaDTO>> GetAllAsync();
        Task CreateAsync(PessoaDTO pessoa);
        Task UpdateAsync(PessoaDTO pessoa);
        Task DeleteAsync(Guid pessoaId);
    }
}
