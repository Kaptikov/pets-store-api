using Microsoft.EntityFrameworkCore;
using pets_store_api.Data;
using pets_store_api.Models;

namespace pets_store_api.Services.FavouriteItemService
{
    public class FavouriteItemService : IFavouriteItemService
    {
        private readonly DataContext _context;

        public FavouriteItemService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<FavouriteItem>> AddFavouriteItem(FavouriteItem favouriteItem)
        {
            _context.FavouriteItems.Add(favouriteItem);
            await _context.SaveChangesAsync();

            return await _context.FavouriteItems.ToListAsync();
        }

        public async Task<List<FavouriteItem>?> DeteleFavouriteItem(int id)
        {
            var favouriteItem = await _context.FavouriteItems.FindAsync(id);
            if (favouriteItem is null)
                return null;

            _context.FavouriteItems.Remove(favouriteItem);
            await _context.SaveChangesAsync();
            return await _context.FavouriteItems.ToListAsync();
        }

        public async Task<List<FavouriteItem>> GetAllFavouriteItem()
        {
            var favouriteItems = await _context.FavouriteItems.ToListAsync();
            return favouriteItems;
        }

        public async Task<FavouriteItem?> GetSingleFavouriteItem(int id)
        {
            var favouriteItem = await _context.FavouriteItems.FindAsync(id);
            if (favouriteItem is null)
                return favouriteItem;

            return favouriteItem;
        }

        public async Task<List<FavouriteItem>?> UpdateFavouriteItem(int id, FavouriteItem request)
        {
            var favouriteItem = await _context.FavouriteItems.FindAsync(id);
            if (favouriteItem is null)
                return null;

            //favouriteItem.Name = request.Name;
            //favouriteItem.Email = request.Email;
            //favouriteItem.PhoneNumber = request.PhoneNumber;

            await _context.SaveChangesAsync();

            return await _context.FavouriteItems.ToListAsync();
        }
    }
}
