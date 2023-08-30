using BackOffice.Domain.DTO;
namespace BackOffice.Domain.Interfaces
{
    public interface IPessoaService
    {
        Task<PessoaDTO> GetByIdAsync(Guid pessoaId);
        Task<IEnumerable<PessoaDTO>> GetAllAsync();
        Task CreateAsync(PessoaDTO pessoa);
        Task UpdateAsync(PessoaDTO pessoa);
        Task DeleteAsync(Guid pessoaId);
    }
}
