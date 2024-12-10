using FG.Server.Notification.Api.Models.Request;
using FG.Server.Notification.Api.Models.Responce;
using Refit;

namespace FG.Server.Api.Clients.Notification.Controllers;

public interface INotificationController
{
	[Get("/Notification/{userId}")]
	public Task<List<NotificationResponce>> GetPushs(
		Guid userId,
		[Query] int offset,
		[Query] int count);

	[Post("/Notification/Send")]
	public Task SendPush(
		[Query] Guid userId,
		[Body] SendMessageOptions options);
}
