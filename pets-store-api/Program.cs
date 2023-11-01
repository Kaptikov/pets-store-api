using Microsoft.EntityFrameworkCore;
using pets_store_api.Data;
using pets_store_api.Services.CartItemService;
using pets_store_api.Services.CartService;
using pets_store_api.Services.CategoryService;
using pets_store_api.Services.FavouriteItemService;
using pets_store_api.Services.FavouriteService;
using pets_store_api.Services.ProductImgService;
using pets_store_api.Services.ProductService;
using pets_store_api.Services.SubcategoryService;
using pets_store_api.Services.UserService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DataContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductImgService, ProductImgService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ISubcategoryService, SubcategoryService>();
builder.Services.AddScoped<IFavouriteItemService, FavouriteItemService>();
builder.Services.AddScoped<IFavouriteService, FavouriteService>();
builder.Services.AddScoped<ICartItemService, CartItemService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddDbContext<DataContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
