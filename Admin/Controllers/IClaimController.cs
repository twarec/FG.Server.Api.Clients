using FG.Server.Api.Clients.Admin.Models.Request;
using FG.Server.Api.Clients.Admin.Models.Responce;
using Refit;

namespace FG.Server.Api.Clients.Admin.Controllers
{
	public interface IClaimController
	{
		[Get("/api/Claim/{grouped}/Range")]
		public Task<List<ClaimResponce>> GetRangeAsync([Query] int offset, [Query] int count, string grouped);

		[Get("/api/Claim/Many")]
		public Task<List<ClaimResponce>> GetManyAsync(int[] ids);

		[Get("/api/Claim/{grouped}/Next")]
		public Task<ClaimResponce> GetNextAsync(string grouped);

		[Get("/api/Claim/{grouped}/Range/Count")]
		public Task<int> GetCountAsync(string grouped);

		[Post("/api/Claim/Responce")]
		public Task<ClaimResponce> AddResponceAsync([Body] ClaimResponceOptions options);

		[Post("/api/Claim/{id}/Blocked/Time")]
		public Task<ModerationResponce> BlockForTimeAsync(int id, [Query] long seconds);
	}
}
