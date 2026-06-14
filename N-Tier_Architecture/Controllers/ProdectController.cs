using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N_Tier_Architecture.Service;

namespace N_Tier_Architecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdectController : ControllerBase
    {
      IProductService _productService;

        public ProdectController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAProdects()
        {
            var Products = _productService.GetAllFromServices();
            return Ok(Products);
        }

    }
}
