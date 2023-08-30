using BackOffice.Doamin.Entities;
using BackOffice.Domain.DTO;
using BackOffice.Domain.Repository;
using BackOffice.Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace BackOffice.Infra.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly AppDbContext _dbContext;

        public PessoaRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Pessoa>> GetAllAsync()
        {
            return await _dbContext.Pessoas.ToListAsync();
        }

        public async Task<Pessoa> GetByIdAsync(Guid id)
        {
            return await _dbContext.Pessoas.FindAsync(id);
        }

        public async Task CreateAsync(Pessoa pessoa)
        {
            _dbContext.Pessoas.Add(pessoa);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Pessoa pessoa)
        {
            _dbContext.Entry(pessoa).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid pessoaId)
        {
            var remove = await GetByIdAsync(pessoaId);

            if (remove != null)
            {
                _dbContext.Pessoas.Remove(remove);
                await _dbContext.SaveChangesAsync();
            }
        }

    }
}
