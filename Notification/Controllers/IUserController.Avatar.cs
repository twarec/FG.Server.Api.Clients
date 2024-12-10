using FG.Server.Api.Clients.User.Models.Request.User;
using Refit;

namespace FG.Server.Api.Clients.User.Controllers
{
	public partial interface IUserController
	{
		[Get("/User/Images/Avatar/{avatarId}")]
		public Task GetAvatar(
			Guid avatarId,
			[Query] string sizeFormat);

		[Post("/User/Images/Avatar")]
		public Task<Guid> SetAvatar(
			[Body] SetAvatarOptions options);

		[Multipart]
		[Post("/User/Images/Avatar/Form")]
		public Task<Guid> SetAvatarFromForm(
			[AliasAs("avatar")] StreamPart stream);

		[Delete("/User/Images/Avatar")]
		public Task<bool> DeleteAvatar();
	}
}
