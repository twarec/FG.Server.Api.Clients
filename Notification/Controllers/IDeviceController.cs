using FG.Server.Api.Clients.Admin.Models.Responce;
using Refit;

namespace FG.Server.Api.Clients.Notification.Controllers;

public interface IDeviceController
{
	[Put("/Notification/Device/Disconnect/{userId}")]
	public Task<UserResponce> DisconnectDevice(
		Guid userId,
		[Query] string deviceId);

	[Delete("/Notification/Device/{deviceId}")]
	public Task RemoveDevice(
		string deviceId);
}
