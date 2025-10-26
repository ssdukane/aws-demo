using Microsoft.AspNetCore.Mvc;
using OMB.Infra.Domain.Entities;
using OMB.Infra.Repository;

namespace cqrs_3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        IOMBConfiguration _iOMBConfiguraton;
        public HomeController(IOMBConfiguration iOMBConfiguration)
        {
            _iOMBConfiguraton= iOMBConfiguration;
        }

        [HttpPost]
        public IActionResult Test()
        {
            var context = _iOMBConfiguraton.GetDBContext();
            return Ok();
        }
    }
}
