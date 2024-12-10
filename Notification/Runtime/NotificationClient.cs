using FG.Server.Api.Clients.Notification.Controllers;

namespace FG.Server.Api.Clients.Notification.Runtime;

public class NotificationClient(HttpClient client) : INotificationClient
{
	public Uri? Url => client.BaseAddress;
	public HttpClient HttpClient => client;

	public IUserController UserController { get; } = Refit.RestService.For<IUserController>(client);
	public IDeviceController DeviceController { get; } = Refit.RestService.For<IDeviceController>(client);
	public INotificationController NotificationController { get; } = Refit.RestService.For<INotificationController>(client);
}
