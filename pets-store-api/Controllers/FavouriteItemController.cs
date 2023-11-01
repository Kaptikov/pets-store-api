using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pets_store_api.Models;
using pets_store_api.Services.FavouriteItemService;

namespace pets_store_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavouriteItemController : ControllerBase
    {
        private readonly IFavouriteItemService _FavouriteItemService;

        public FavouriteItemController(IFavouriteItemService FavouriteItemService)
        {
            _FavouriteItemService = FavouriteItemService;
        }

        [HttpGet]
        public async Task<ActionResult<List<FavouriteItem>>> GetAllFavouriteItem()
        {
            return await _FavouriteItemService.GetAllFavouriteItem();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FavouriteItem>> GetSingleFavouriteItem(int id)
        {
            var result = await _FavouriteItemService.GetSingleFavouriteItem(id);
            if (result is null)
                return NotFound("Product not found.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<FavouriteItem>>> AddProduct(FavouriteItem FavouriteItem)
        {
            var result = await _FavouriteItemService.AddFavouriteItem(FavouriteItem);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<FavouriteItem>>> UpdateFavouriteItem(int id, FavouriteItem request)
        {
            var result = await _FavouriteItemService.UpdateFavouriteItem(id, request);
            if (result is null)
                return NotFound("FavouriteItem not found.");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<FavouriteItem>>> DeleteFavouriteItem(int id)
        {
            var result = await _FavouriteItemService.DeteleFavouriteItem(id);
            if (result is null)
                return NotFound("FavouriteItem not found.");

            return Ok(result);
        }
    }
}
