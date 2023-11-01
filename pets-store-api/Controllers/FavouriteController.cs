using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pets_store_api.Models;
using pets_store_api.Services.FavouriteService;

namespace pets_store_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavouriteController : ControllerBase
    {
        private readonly IFavouriteService _FavouriteService;

        public FavouriteController(IFavouriteService FavouriteService)
        {
            _FavouriteService = FavouriteService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Favourite>>> GetAllFavourite()
        {
            return await _FavouriteService.GetAllFavourite();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Favourite>> GetSingleFavourite(int id)
        {
            var result = await _FavouriteService.GetSingleFavourite(id);
            if (result is null)
                return NotFound("Product not found.");

            return Ok(result);
        }

    }
}
