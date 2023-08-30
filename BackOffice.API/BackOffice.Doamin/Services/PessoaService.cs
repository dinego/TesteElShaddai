using AutoMapper;
using BackOffice.Doamin.Entities;
using BackOffice.Domain.DTO;
using BackOffice.Domain.Interfaces;
using BackOffice.Domain.Repository;

namespace BackOffice.Domain.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;
        private readonly IMapper _mapper;
        public PessoaService(
            IPessoaRepository pessoaRepository, 
            IMapper mapper) 
        {
            _pessoaRepository = pessoaRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(PessoaDTO pessoa)
        {
            var pessoaMapper = _mapper.Map<Pessoa>(pessoa);
            await _pessoaRepository.CreateAsync(pessoaMapper);
        }

        public async Task DeleteAsync(Guid pessoaId)
        {
            await _pessoaRepository.DeleteAsync(pessoaId);
        }

        public async Task<PessoaDTO> GetByIdAsync(Guid pessoaId)
        {

            var pessoa = _pessoaRepository.GetByIdAsync(pessoaId);

            if (pessoa == null)
                return null;

            var pessoaDTO = _mapper.Map<PessoaDTO>(pessoa);

            return pessoaDTO;
        }

        public async Task<IEnumerable<PessoaDTO>> GetAllAsync()
        {
            var pessoas = await _pessoaRepository.GetAllAsync();

            if (pessoas == null)
                return null;

            var pessoasDTO = _mapper.Map<IEnumerable<PessoaDTO>>(pessoas);

            return pessoasDTO;
        }

        public async Task UpdateAsync(PessoaDTO pessoa)
        {
            var pessoaMapper = _mapper.Map<Pessoa>(pessoa);
            await _pessoaRepository.UpdateAsync(pessoaMapper);
        }
    }
}
