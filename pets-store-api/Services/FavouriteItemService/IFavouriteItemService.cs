using pets_store_api.Models;

namespace pets_store_api.Services.FavouriteItemService
{
    public interface IFavouriteItemService
    {
        Task<List<FavouriteItem>> GetAllFavouriteItem();
        Task<FavouriteItem>? GetSingleFavouriteItem(int id);

        Task<List<FavouriteItem>> AddFavouriteItem(FavouriteItem favouriteItem);

        Task<List<FavouriteItem>?> UpdateFavouriteItem(int id, FavouriteItem request);

        Task<List<FavouriteItem>?> DeteleFavouriteItem(int id);
    }
}
