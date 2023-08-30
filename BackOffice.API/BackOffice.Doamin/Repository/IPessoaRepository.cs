using BackOffice.Doamin.Entities;
using BackOffice.Domain.DTO;

namespace BackOffice.Domain.Repository
{
    public interface IPessoaRepository
    {
        Task<IEnumerable<Pessoa>> GetAllAsync();
        Task<Pessoa> GetByIdAsync(Guid id);
        Task CreateAsync(Pessoa pessoa);
        Task UpdateAsync(Pessoa pessoa);
        Task DeleteAsync(Guid id);
    }
}
