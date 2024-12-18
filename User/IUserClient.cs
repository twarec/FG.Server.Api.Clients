using FG.Server.Api.Clients.User.Controllers;

namespace FG.Server.Api.Clients.User;

public interface IUserClient
{
	public Uri? Url { get; }
	public HttpClient HttpClient { get; }

	public Controllers.IHEUserController HEUserContoller { get; }
	public Controllers.IUserController UserController { get; }
	public IAnalyticsController AnalyticsController { get; }
	public IAuthorizateController AuthorizateController { get; }
}
