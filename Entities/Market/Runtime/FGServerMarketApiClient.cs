using FG.Server.Api.Clients.Entities.Market.Controllers;

namespace FG.Server.Api.Clients.Entities.Market.Runtime
{
	public class FGServerMarketApiClient : IFGServerMarketApiClient
	{
		private static HttpClient? _client;
		public ICategoryController CategoryController { get; }
		public IMarketController MarketController { get; }
		public IMemberController MemberController { get; }
		public IOrderController OrderController { get; }
		public IProductController ProductController { get; }

		public FGServerMarketApiClient(HttpClient client)
		{
			_client = client;
			CategoryController = Refit.RestService.For<ICategoryController>(_client);
			MarketController = Refit.RestService.For<IMarketController>(_client);
			MemberController = Refit.RestService.For<IMemberController>(_client);
			OrderController = Refit.RestService.For<IOrderController>(_client);
			ProductController = Refit.RestService.For<IProductController>(_client);
		}
	}
}