namespace pets_store_api.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public User? Users { get; set; }
        public List<CartItem> CartItems { get; set; } = new();
    }
}
