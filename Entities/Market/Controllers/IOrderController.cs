using Refit;

namespace FG.Server.Api.Clients.Entities.Market.Controllers
{
	public interface IOrderController
	{
		[Get("/Market/[Controller]/{OrderId}")]
		public Task<Models.Responce.Order> Get(Guid OrderId);
		[Get("/Market/[Controller]/Range/Market/{MarketId}")]
		public Task<ICollection<Models.Responce.Order>> GetByMarket(Guid MarketId, [Query] int offset, [Query] int count);
		[Get("/Market/[Controller]/Range/User/{UserId}")]
		public Task<ICollection<Models.Responce.Order>> GetByUser(Guid UserId, [Query] int offset, [Query] int count);
		[Get("/Market/[Controller]/Range/Organization/{OrganizationId}")]
		public Task<ICollection<Models.Responce.Order>> GetByOrganization(Guid OrganizationId, [Query] int offset, [Query] int count);
		[Post("/Market/[Controller]/{MarketId}")]
		public Task<Models.Responce.Order> Add(Guid MarketId, [Body] Models.Request.AddOrder addOrder);
		[Put("/Market/Organization/[Controller]/{OrderId}/Status")]
		public Task OrganizationUpdateStatus(Guid OrderId, [Query] Models.Responce.Enums.OrderStatus status);
		[Put("/Market/User/[Controller]/{OrderId}/Cancel")]
		public Task UserUpdateStatus(Guid OrderId, [Query] Models.Responce.Enums.OrderStatus status);
	}
}