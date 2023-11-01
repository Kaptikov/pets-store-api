using System.Text.Json.Serialization;

namespace pets_store_api.Models
{
    public class FavouriteItem
    {
        public int Id { get; set; }
        public int? FavouriteId { get; set; }
        [JsonIgnore]
        public Favourite? Favourites { get; set; }
        public int? ProductId { get; set; }
        public Product? Products { get; set; }
    }
}
