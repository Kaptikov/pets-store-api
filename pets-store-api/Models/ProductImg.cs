namespace pets_store_api.Models
{
    public class ProductImg
    {
        public int Id { get; set; }
        public string? imgUrl { get; set; }
        public int? ProductId { get; set; }
        public Product? Products { get; set; }
    }
}
