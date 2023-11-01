using System.Text.Json.Serialization;

namespace pets_store_api.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int? CartId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        [JsonIgnore]
        public Cart? Carts { get; set; }
        [JsonIgnore]
        public Product? Products { get; set; }
        //public List<Product> Products { get; set; } = new();
    }
}
