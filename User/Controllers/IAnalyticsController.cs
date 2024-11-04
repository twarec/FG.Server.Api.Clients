using Refit;

namespace FG.Server.Api.Clients.User.Controllers
{
	public interface IAnalyticsController
    {
		[Get("/")]
		public Task Zagluhka();
	}
}
