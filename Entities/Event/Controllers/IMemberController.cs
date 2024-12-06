using Refit;

namespace FG.Server.Api.Clients.Entities.Event.Controllers
{
    public interface IMemberController
    {
        [Get("/Events/Member/{MemberId}")]
        public Task<Models.Response.Member> Get(Guid MemberId);
        [Get("/Events/Member/Range/Event/{EventId}")]
        public Task<ICollection<Models.Response.Member>> GetByEvent(Guid EventId, [Query] int offset, [Query] int count);
        [Post("/Events/{EventId}/Member")]
        public Task<Models.Response.Member> Add(Guid EventId, [Query] Guid memberId);
        [Delete("/Events/Member/{MemberId}")]
        public Task Delete(Guid MemberId);
        [Put("/Events/Member/{MemberId}/Info")]
        public Task<Models.Response.MemberInform> UpdateInform(Guid MemberId, [Body] Models.Request.UpdateMemberInform updateMemberInform);
        [Put("/Events/Member/{MemberId}/Tags")]
        public Task<ICollection<Models.Response.Tag>> UpdateTags(Guid MemberId, [Body] Models.Request.UpdateMemberTags updateMemberTags);
    }
}