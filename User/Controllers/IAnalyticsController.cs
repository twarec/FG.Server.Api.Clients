using Refit;

namespace FG.Server.Api.Clients.User.Controllers
{
	public interface IAnalyticsController
    {
		[Get("/User/Analytics/User/Check")]
		public Task<bool> CheckAvalaibleUser(
			[Query] Guid userId);

		//return list avalaible users
		[Get("/User/Analytics/User/Many/Check")]
		public Task<List<Guid>> CheckAvalaibleManyUsers(
			[Query] List<Guid> usersId);

		[Get("/User/Analytics/User/Check/Email")]
		public Task<bool> CheckAvalaibleUserFromEmail(
			[Query] string email);

		//return list avalaible users
		[Get("/User/Analytics/User/Many/Check/Email")]
		public Task<List<string>> CheckAvalaibleManyUsersFromEmail(
			[Query] List<string> emails);

		

		//if list empty return all
		[Get("/User/Analytics/Tags")]
		public Task<Dictionary<string, string?>> GetTags(
			[Query] Guid userId,
			[Query] List<string> tagsKey);

		[Post("/User/Analytics/Tags")]
		public Task<Dictionary<string, string?>> SetTags(
			[Query] Guid userId,
			[Body] Dictionary<string, string?> tags);

		[Delete("/User/Analytics/Tags")]
		public Task DeleteTags(
			[Query] Guid userId,
			[Body] List<string> tagsKey);

		[Delete("/User/Analytics/Tags/All")]
		public Task DeleteAllTags(
			[Query] Guid userId);


		[Get("/User/Analytics/Roles")]
		public Task<List<string>> GetRoles(
			[Query] Guid userId);

		[Post("/User/Analytics/Roles")]
		public Task<List<string>> SetRoles(
			[Query] Guid userId,
			[Body] List<string> roles);

		[Delete("/User/Analytics/Roles")]
		public Task DeleteRoles(
			[Query] Guid userId,
			[Body] List<string> roles);

		[Delete("/User/Analytics/Roles/All")]
		public Task DeleteAllRoles(
			[Query] Guid userId);


	}
}
