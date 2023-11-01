namespace pets_store_api.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateOrder { get; set; }
        public Cart Carts { get; set; }
        // public List<OrderItem> OrderItems { get; set;}
        //public List<Cart> Carts { get; set; } = new();
    }
}
