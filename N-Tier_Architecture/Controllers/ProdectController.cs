using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N_Tier_Architecture.Service;

namespace N_Tier_Architecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdectController : ControllerBase
    {
        ProdectService _prodectService;

        public ProdectController(IConfiguration configuration)
        {
            _prodectService = new ProdectService(configuration);
        }

        [HttpGet]
        public IActionResult GetAllProdects()
        {
            var Products = _prodectService.GetAllFromServices();
            return Ok(Products);
        }

    }
}
