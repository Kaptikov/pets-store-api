using pets_store_api.Models;

namespace pets_store_api.Services.FavouriteService
{
    public interface IFavouriteService
    {
        Task<List<Favourite>> GetAllFavourite();
        Task<Favourite>? GetSingleFavourite(int id);

        //Task<List<Favourite>> AddFavourite(Favourite favourite);

        //Task<List<Favourite>?> UpdateFavourite(int id, Favourite request);

        //Task<List<Favourite>?> DeteleFavourite(int id);
    }
}
