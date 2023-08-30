using Microsoft.AspNetCore.Mvc;

namespace BackOffice.API.Controllers
{
    [Route("api/[controller]/[action]")]
    public class DepartamentoController : Controller
    {
        [HttpPost]
        public IActionResult Create()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Edit(string id)
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(string id)
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult Get(string id)
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }
    }
}
