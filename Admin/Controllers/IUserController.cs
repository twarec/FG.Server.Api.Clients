using FG.Server.Api.Clients.Admin.Models;
using FG.Server.Api.Clients.Admin.Models.Request;
using FG.Server.Api.Clients.Admin.Models.Responce;
using Refit;

namespace FG.Server.Api.Clients.Admin.Controllers
{
	public interface IUserController
	{
		[Get("/api/User/Range")]
		public Task<List<UserResponce>> GetRangeAsync([Query] int offset, [Query] int count, [Query] bool isShowBlocked);

		[Get("/api/User/Range/{role}")]
		public Task<List<UserResponce>> GetRangeByRoleAsync([Query] int offset, [Query] int count, [Query] bool isShowBlocked, UserRole role);

		[Get("/api/User/Range/{role}/Count")]
		public Task<int> GetCountByRoleAsync(UserRole role, [Query] bool isShowBlocked);

		[Get("/api/User/{userId}/Connection/Range")]
		public Task<List<UserConnectionResponce>> GetConnectionsAsync([Query] int offset, [Query] int count, int userId);

		[Get("/api/User/{userId}/Connection/Range/Count")]
		public Task<int> GetConnectionsCountAsync([Query] int offset, [Query] int count, int userId);

		[Get("/api/User/{userId}/Moderation/Range")]
		public Task<List<ModerationResponce>> GetModerationsAsync(int userId, [Query] int offset, [Query] int count);

		[Get("/api/User/{userId}/Moderation/Range/Count")]
		public Task<int> GetModerationsCountAsync(int userId);

		[Get("/api/User/{userId}/Claim/Range")]
		public Task<List<ClaimResponce>> GetClaimsAsync(int userId, [Query] int offset, [Query] int count);

		[Get("/api/User/{userId}/Claim/Range/Count")]
		public Task<int> GetClaimsCountAsync(int userId);

		[Get("/api/User/Many")]
		public Task<List<UserResponce>> GetManyAsync([Query] int[] users);

		[Get("/api/User/Range/All/Count")]
		public Task<int> GetAllCountAsync();

		[Put("/api/User/{userId}/Status")]
		public Task UpdateStatusAsync(int userId, [Query] UserStatus status);

		[Post("/api/User/Avatar")]
		public Task SetAvatarAsync(UserAvatarOptions options);

		[Post("/api/User/Avatar/{options.Id}")]
		public Task SetAvatarAsAdminAsync(UserAvatarAsAdminOptions options);

		[Post("/api/User")]
		public Task<UserResponce> UpdateUserDataAsync(UpdateUserDataOptions options);

		[Post("/api/User/{options.UserId}")]
		public Task<UserResponce> UpdateUserDataAsAdminAsync(UpdateUserDataAsAdminOptions options);
	}
}
