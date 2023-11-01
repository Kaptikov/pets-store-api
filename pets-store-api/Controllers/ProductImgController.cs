using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pets_store_api.Models;
using pets_store_api.Services.ProductImgService;

namespace pets_store_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImgController : ControllerBase
    {
        private readonly IProductImgService _ProductImgService;

        public ProductImgController(IProductImgService ProductImgService)
        {
            _ProductImgService = ProductImgService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductImg>>> GetAllProductImg()
        {
            return await _ProductImgService.GetAllProductImg();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductImg>> GetSingleProductImg(int id)
        {
            var result = await _ProductImgService.GetSingleProductImg(id);
            if (result is null)
                return NotFound("Product not found.");

            return Ok(result);
        }
    }
}
