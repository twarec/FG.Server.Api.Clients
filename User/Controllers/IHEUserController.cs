using FG.Server.Api.Clients.User.Models;
using FG.Server.Api.Clients.User.Models.Request.HEUser;
using FG.Server.Api.Clients.User.Models.Responce.HEUser;
using Refit;

namespace FG.Server.Api.Clients.User.Controllers
{
	public interface IHEUserController
	{
		[Put("/HE/User")]
		public Task<HEUserResponce> EditUser(
			[Query] Guid userId,
			[Body] EditHEUserOptions options);

		[Get("/HE/User/Position")]
		public Task<PositionModel> GetPosition(
			[Query] Guid userId);

		[Post("/HE/User/Position")]
		public Task SetPosition(
			[Query] Guid userId,
			[Body] PositionModel options);

		[Get("/HE/User/Tags")]
		public Task<List<string>> GetTags(
			[Query] Guid userId);

		[Post("/HE/User/Tags")]
		public Task<List<string>> SetTags(
			[Query] Guid userId,
			[Body] List<string> tags);

		[Delete("/HE/User/Tags")]
		public Task<List<string>> DeleteTags(
			[Query] Guid userId,
			[Body] List<string> deletingTags);

		[Delete("/HE/User/Tags/All")]
		public Task DeleteAllTags(
			[Query] Guid userId);
	}
}
