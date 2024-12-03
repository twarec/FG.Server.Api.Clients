using Refit;

namespace FG.Server.Organization.Api.Client.Controllers
{
    public interface IMembersController
    {
        [Get("/Organization/Members/Range/Root/{RootId}")]
        public Task<ICollection<Models.Responce.Member>> GetUserMembers(Guid RootId, [Query] Int32 offset, [Query] Int32 count);
        [Get("/Organization/Members/Range")]
        public Task<ICollection<Models.Responce.Member>> GetUserMembers([Query] Int32 offset, [Query] Int32 count);
        [Put("/Organization/Members/{MemberId}/Info")]
        public Task<Models.Responce.MemberInform> UpdateMemberInform(Guid MemberId, Models.Request.UpdateMemberInform updateMemberInform);
        [Put("/Organization/Members/{MemberId}/Flags")]
        public Task<Models.Responce.Member> UpdateMemberFlags(Guid MemberId, Models.Responce.Enums.MemberFlags flag);
        [Put("/Organization/Members/{MemberId}/Tags")]
        public Task<Models.Responce.MemberInform> UpdateMemberTags(Guid MemberId, Models.Request.UpdateMemberTags updateMemberTags);
    }
}