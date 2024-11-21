using Refit;

namespace FG.Server.Api.Clients.Entities.Market.Controllers
{
    public interface IProductController
    {
        [Post("/Market/Catalog/Category/{CategoryId}/[controller]")]
        public Task<Models.Responce.Product> Add(Guid CategoryId, [Body] Models.Request.AddProduct add);
        [Put("/Market/Catalog/Category/[controller]/{ProductId}")]
        public Task<Models.Responce.Product> Update(Guid ProductId, [Body] Models.Request.UpdateProduct update);
        [Delete("/Market/Catalog/Category/{CategoryId}/[controller]/Many")]
        public Task DeleteMany(Guid CategoryId, [Query] Guid[] productIds);
        [Put("/Market/Catalog/Category/[controller]/{ProductId}/Info")]
        public Task<Models.Responce.ProductInform> UpdateInform(Guid ProductId, [Body] Models.Request.UpdateProductInform updateInfo);
        [Put("/Market/Catalog/Category/[controller]/{ProductId}/Price")]
        public Task<Models.Responce.Price> UpdatePrice(Guid ProductId, [Body] Models.Request.UpdateProductPrice price);
        [Put("/Market/Catalog/Category/[controller]/{ProductId}/Characteristics")]
        public Task<Models.Responce.Characteristics> UpdateCharacteristics(Guid ProductId, [Body] Models.Request.UpdateProductCharacteristics updateCharacteristics);
        [Post("/Market/Catalog/Category/[controller]/{ProductId}/Images")]
        public Task<Models.Responce.ImageInfo> AddImage(Guid ProductId, [Body] Models.Request.AddProductImage addImage);
        [Put("/Market/Catalog/Category/[controller]/Images/{ImageId}")]
        public Task<Models.Responce.ImageInfo> UpdateImage(Guid ImageId, [Body] Models.Request.UpdateProductImage updateImage);
        [Delete("/Market/Catalog/Category/[controller]/{ProductId}/Image/Many")]
        public Task DeleteImages(Guid ProductId, [Body] Models.Request.DeleteProductImages deleteImages);
        [Put("/Market/Catalog/Category/[controller]/{ProductId}/Tags")]
        public Task<ICollection<Models.Responce.Tag>> UpdateTags(Guid ProductId, [Body] Models.Request.UpdateProductTags updateTags);
    }
}