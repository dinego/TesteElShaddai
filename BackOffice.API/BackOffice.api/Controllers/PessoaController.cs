using BackOffice.Application.Interfaces;
using BackOffice.Domain.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BackOffice.API.Controllers
{
    [Route("api/[controller]/[action]")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaAppService _pessoaAppService;
        public PessoaController(IPessoaAppService pessoaAppService) 
        {
            _pessoaAppService = pessoaAppService;
        }

        [HttpPost]
        public IActionResult Create(PessoaDTO pessoa)
        {
            _pessoaAppService.CreateAsync(pessoa);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(PessoaDTO pessoa)
        {
            _pessoaAppService.UpdateAsync(pessoa);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(Guid pessoaId)
        {
            _pessoaAppService.DeleteAsync(pessoaId);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get(Guid pessoaId) 
        {
            return Ok(_pessoaAppService.GetByIdAsync(pessoaId));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync() 
        {
            return Ok(await _pessoaAppService.GetAllAsync().ConfigureAwait(false));
        }
    }
}
