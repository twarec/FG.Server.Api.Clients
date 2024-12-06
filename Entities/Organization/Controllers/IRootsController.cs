using Refit;

namespace FG.Server.Api.Clients.Entities.Organization.Controllers
{
    public interface IRootsController
    {
        [Get("/Organization/Roots/{MemberId}")]
        public Task<ICollection<Models.Response.Root>> GetRootMember(Guid MemberId);
        [Get("/Organization/Roots/Range/Many")]
        public Task<ICollection<Models.Response.Root>> GetRootsMembers([Query] Guid[] MembersId);
    }
}