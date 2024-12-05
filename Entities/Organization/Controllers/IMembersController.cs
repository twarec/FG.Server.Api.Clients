using Refit;

namespace FG.Server.Api.Clients.Entities.Controllers
{
    public interface IMembersController
    {
        [Get("/Organization/Members/Range/Root/{RootId}")]
        public Task<ICollection<Models.Response.Member>> GetUserMembers(Guid RootId, [Query] int offset, [Query] int count);
        [Get("/Organization/Members/Range")]
        public Task<ICollection<Models.Response.Member>> GetUserMembers([Query] int offset, [Query] int count);
        [Put("/Organization/Members/{MemberId}/Info")]
        public Task<Models.Response.MemberInform> UpdateMemberInform(Guid MemberId, Models.Request.UpdateMemberInform updateMemberInform);
        [Put("/Organization/Members/{MemberId}/Flags")]
        public Task<Models.Response.Member> UpdateMemberFlags(Guid MemberId, Models.Response.Enums.MemberFlags flag);
        [Put("/Organization/Members/{MemberId}/Tags")]
        public Task<Models.Response.MemberInform> UpdateMemberTags(Guid MemberId, Models.Request.UpdateMemberTags updateMemberTags);
    }
}