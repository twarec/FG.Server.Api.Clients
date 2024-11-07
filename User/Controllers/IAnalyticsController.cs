using Refit;

namespace FG.Server.Api.Clients.User.Controllers
{
	public interface IAnalyticsController
    {
		//if list empty return all
		[Get("/User/Analytics/Tags")]
		public Task<Dictionary<string, string?>> GetTags(
			[Query] Guid userId,
			[Query] List<string>? tagsKey);

		[Post("/User/Analytics/Tags")]
		public Task<Dictionary<string, string?>> SetTags(
			[Query] Guid userId,
			[Query] Dictionary<string, string?> tags);

		[Delete("/User/Analytics/Tags")]
		public Task DeleteTags(
			[Query] Guid userId,
			[Body] List<string> tagsKey);

		[Delete("/User/Analytics/Tags/All")]
		public Task DeleteAllTags(
			[Query] Guid userId);
	}
}
