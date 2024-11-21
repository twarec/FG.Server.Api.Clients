using FG.Server.Api.Clients.User.Models.Request.User;
using FG.Server.Api.Clients.User.Models.Responce.User;
using Refit;

namespace FG.Server.Api.Clients.User.Controllers
{
	public partial interface IUserController
	{
		[Get("/User/Properties")]
		public Task<List<UserPropertyResponce>> GetProperties(
			[Query] UserPropertyOptions options);

		[Get("/User/Properties/{userId}")]
		public Task<List<UserPropertyResponce>> GetProperties(
			Guid userId,
			[Query] UserPropertyOptions options);

		[Get("/User/Properties/Stacks")]
		public Task<UserStackPropertyResponce> GetAllUserStacksProperties();

		[Get("/User/Properties/Stacks{userId}")]
		public Task<UserStackPropertyResponce> GetAllUserStacksProperties(
			Guid userId);

		[Post("/User/Properties")]
		public Task<UserStackPropertyResponce> SetProperties(
			[Body] SetUserPropertyOptions options);

		[Get("/User/Properties/Stacks/Names")]
		public Task<List<string>> GetUserNamesStacks();

		[Get("/User/Properties/Stacks/Names/{userId}")]
		public Task<List<string>> GetUserNamesStacks(
			Guid userId);

		[Get("/User/Properties/Stacks/Stack")]
		public Task<UserStackPropertyResponce> GetUserStackProperties(
			[Query] string stackName);

		[Get("/User/Properties/Stacks/Stack/{userId}")]
		public Task<UserStackPropertyResponce> GetUserStackProperties(
			Guid userId,
			[Query] string stackName);

		[Delete("/User/Properties")]
		public Task<UserStackPropertyResponce> RemoveProperties(
			[Body] UserPropertyOptions options);

		[Delete("/User/Properties/Stack")]
		public Task RemoveStackProperties(
			[Query] string stackName);
	}
}
