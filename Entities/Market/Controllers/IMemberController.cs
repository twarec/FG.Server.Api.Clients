using Refit;

namespace FG.Server.Api.Clients.Entities.Market.Controllers
{
	public interface IMemberController
	{
		[Get("/Market/Member/{MemberId}")]
		public Task<Models.Responce.Member> Get(Guid MemberId);
		[Get("/Market/Member/Range/MarketInfo/{MarketId}")]
		public Task<ICollection<Models.Responce.Member>> GetByMarket(Guid MarketId);
		[Post("/Market/{MarketId}/Member")]
		public Task<Models.Responce.Member> AddMember(Guid MarketId, [Query] Guid memberId);
		[Delete("/Market/Member/{MemberId}")]
		public Task DeleteMember(Guid MemberId);
		[Put("/Market/Member/{MemberId}/Info")]
		public Task<Models.Responce.MemberInform> UpdateMemberInform(Guid MemberId, [Body] Models.Request.UpdateMemberInform updateMemberInform);
		[Put("/Market/Member/{MemberId}/Tags")]
		public Task<ICollection<Models.Responce.Tag>> UpdateMemberTags(Guid MemberId, [Body] Models.Request.UpdateMemberTags updateMemberTags);
	}
}