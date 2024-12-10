using FG.Server.Api.Clients.Admin.Models.Responce;
using FG.Server.Notification.Api.Models.Request;
using Refit;

namespace FG.Server.Api.Clients.Notification.Controllers;

public partial interface IUserController
{
	[Post("/Notification/User/Connect/{userId}")]
	public Task<UserResponce> ConnectUser(
		Guid userId,
		[Body] DeviceOptions options);

	[Delete("/Notification/User/{userId}")]
	public Task DeleteUser(
		Guid userId);
}