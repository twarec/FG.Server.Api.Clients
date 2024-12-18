using FG.Server.Api.Clients.User.Controllers;

namespace FG.Server.Api.Clients.User.Runtime;

public class UserClient(HttpClient client) : IUserClient
{
	public Uri? Url => client.BaseAddress;
	public HttpClient HttpClient => client;

	public IUserController UserController { get; } = Refit.RestService.For<IUserController>(client);
	public IAuthorizateController AuthorizateController { get; } = Refit.RestService.For<IAuthorizateController>(client);
	public IAnalyticsController AnalyticsController { get; } = Refit.RestService.For<IAnalyticsController>(client);
	public IHEUserController HEUserContoller { get; } = Refit.RestService.For<IHEUserController>(client);
}
