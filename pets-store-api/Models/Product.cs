using System.Text.Json.Serialization;

namespace pets_store_api.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Price { get; set; }
        public int? SubcategoryId { get; set; }
        //public int? ProductImgId { get; set; }

        [JsonIgnore]
        public Subcategory? Subcategories { get; set; }
        // [JsonIgnore]
        //public Cart? Cart { get; set; }
        [JsonIgnore]
        public List<ProductImg> ProductImgs { get; set; } = new();
        [JsonIgnore]
        public List<CartItem> CartItems { get; set; } = new();
        [JsonIgnore]
        public List<FavouriteItem> FavouriteItems { get; set; } = new();
    }
}
