using FG.Server.Api.Clients.Admin.Models.Responce;
using FG.Server.Api.Clients.User.Models;
using FG.Server.Api.Clients.User.Models.Request.HEUser;
using FG.Server.Api.Clients.User.Models.Responce.HEUser;
using Refit;

namespace FG.Server.Api.Clients.User.Controllers
{
	public interface IHEUserController
	{
		[Put("/HE/User")]
		public Task<UserResponce> EditUser(
			[Body] EditHEUserOptions options);

		[Get("/HE/User/Position")]
		public Task<PositionModel> GetPosition();

		[Get("/HE/User/Position/{userId}")]
		public Task<PositionModel> GetPosition(
			Guid userId);

		[Post("/HE/User/Position")]
		public Task SetPosition(
			[Body] PositionModel options);

		[Get("/HE/User/Tags")]
		public Task<List<string>> GetTags();

		[Get("/HE/User/Tags/{userId}")]
		public Task<List<string>> GetTags(
			Guid userId);

		[Post("/HE/User/Tags")]
		public Task<List<string>> SetTags(
			[Body] List<string> tags);

		[Delete("/HE/User/Tags")]
		public Task<List<string>> DeleteTags(
			[Body] List<string> deletingTags);

		[Delete("/HE/User/Tags/All")]
		public Task DeleteAllTags();
	}
}
