using pets_store_api.Models;

namespace pets_store_api.Services.ProductImgService
{
    public interface IProductImgService
    {
        Task<List<ProductImg>> GetAllProductImg();
        Task<ProductImg>? GetSingleProductImg(int id);

        /*Task<List<ProductImg>> AddProductImg(ProductImg productImg);

        Task<List<ProductImg>?> UpdateProductImg(int id, ProductImg request);

        Task<List<ProductImg>?> DeteleProductImg(int id);*/
    }
}
