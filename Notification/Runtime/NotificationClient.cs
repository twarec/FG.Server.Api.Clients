using FG.Server.Api.Clients.Notification.Controllers;
using FG.Server.Api.Clients.User.Controllers;

namespace FG.Server.Api.Clients.Notification.Runtime;

public class NotificationClient(HttpClient client) : INotificationClient
{
	public Uri? Url => client.BaseAddress;
	public HttpClient HttpClient => client;

	public IUserController UserController { get; } = Refit.RestService.For<IUserController>(client);
	public IDeviceController AuthorizateController { get; } = Refit.RestService.For<IDeviceController>(client);
	public INotificationController AnalyticsController { get; } = Refit.RestService.For<INotificationController>(client);
	public IHEUserController HEUserContoller { get; } = Refit.RestService.For<IHEUserController>(client);
}
