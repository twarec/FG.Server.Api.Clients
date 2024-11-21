using FG.Server.Api.Clients.Entities.Market.Controllers;

namespace FG.Server.Api.Clients.Entities.Market
{
	public interface IFGServerMarketApiClient
	{
		public ICategoryController CategoryController { get; }
		public IMarketController MarketController { get; }
		public IMemberController MemberController { get; }
		public IOrderController OrderController { get; }
		public IProductController ProductController { get; }
	}
}