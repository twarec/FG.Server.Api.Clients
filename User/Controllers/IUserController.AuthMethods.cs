using FG.Server.Api.Clients.User.Models.Request.Authorization;
using FG.Server.Api.Clients.User.Models.Responce.User;
using Refit;

namespace FG.Server.Api.Clients.User.Controllers
{
	public partial interface IUserController
	{
		[Get("/User/Connect/AuthMethod/Email")]
		public Task<AddEmailAuthorizationResponce> AddEmail(
			[Body] AuthorizationEmailOptions options);
	}
}
