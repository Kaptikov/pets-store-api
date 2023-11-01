using Microsoft.EntityFrameworkCore;
using pets_store_api.Data;
using pets_store_api.Models;

namespace pets_store_api.Services.FavouriteService
{
    public class FavouriteService : IFavouriteService
    {

        private readonly DataContext _context;

        public FavouriteService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Favourite>> GetAllFavourite()
        {
            var favourites = await _context.Favourites.ToListAsync();
            return favourites;
        }

        public async Task<Favourite?> GetSingleFavourite(int id)
        {
            var favourite = await _context.Favourites.FindAsync(id);
            if (favourite is null)
                return favourite;

            return favourite;
        }
    }
}
