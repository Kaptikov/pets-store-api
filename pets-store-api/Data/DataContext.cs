using Microsoft.EntityFrameworkCore;
using pets_store_api.Models;

namespace pets_store_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base ( options ) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
        public DbSet<FavouriteItem> FavouriteItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<ProductImg> ProductImgs { get; set; }
    }
}
