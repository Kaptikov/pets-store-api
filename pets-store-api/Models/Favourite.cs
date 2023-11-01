namespace pets_store_api.Models
{
    public class Favourite
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public List<FavouriteItem> FavouriteItems { get; set; } = new();
    }
}
