using BackOffice.Application.Interfaces;
using BackOffice.Domain.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BackOffice.API.Controllers
{
    [Route("api/[controller]/[action]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioAppService _usuarioAppService;
        public UsuarioController(IUsuarioAppService usuarioAppService) 
        {
            _usuarioAppService = usuarioAppService;
        }


        [HttpPost]
        public IActionResult Create(UsuarioDTO usuario)
        {
            _usuarioAppService.Create(usuario);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(UsuarioDTO usuario)
        {
            _usuarioAppService.Update(usuario);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(string id)
        {
            _usuarioAppService.Delete(id);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get(string id)
        {
            
            return Ok(_usuarioAppService.Get(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_usuarioAppService.GetAll());
        }
    }
}
