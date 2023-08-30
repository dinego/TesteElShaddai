using BackOffice.Application.Interfaces;
using BackOffice.Domain.DTO;
using BackOffice.Domain.Interfaces;

namespace BackOffice.Application.AppServices
{
    public class PessoaAppService : IPessoaAppService
    {
        private readonly IPessoaService _pessoaService;
        public PessoaAppService(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        public Task CreateAsync(PessoaDTO pessoa)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid pessoaId)
        {
            throw new NotImplementedException();
        }

        public Task<PessoaDTO> GetByIdAsync(Guid pessoaId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PessoaDTO>> GetAllAsync()
        {
            return await _pessoaService.GetAllAsync();
        }

        public Task UpdateAsync(PessoaDTO pessoa)
        {
            throw new NotImplementedException();
        }
    }
}
