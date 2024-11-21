using Refit;

namespace FG.Server.Api.Clients.Entities.Market.Controllers
{
	public interface ICategoryController
	{
		[Post("/Market/{MarketId}/Catalog/[controller]")]
		public Task<Models.Responce.Category> Add(Guid MarketId, [Body] Models.Request.AddCategory add);
		[Put("/Market/Catalog/[controller]/{CategoryId}")]
		public Task<Models.Responce.Category> Update(Guid CategoryId, [Body] Models.Request.UpdateCategory update);
		[Delete("/Market/{MarketId}/Catalog/[controller]/Many")]
		public Task DeleteMany(Guid MarketId, [Query] Guid[] CategoryIds);
		[Put("/Market/Catalog/[controller]/{CategoryId}/Inform")]
		public Task<Models.Responce.CategoryInform> UpdateInform(Guid CategoryId, [Body] Models.Request.UpdateCategoryInform updateInform);
	}
}