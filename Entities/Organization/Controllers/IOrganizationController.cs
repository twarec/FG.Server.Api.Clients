using Refit;

namespace FG.Server.Api.Clients.Entities.Controllers
{
    public interface IOrganizationController
    {
        [Get("/Organization/{OrganizationId}/Roots/{RootId}/CanExecute")]
        public Task<Guid> CheckRootOrganization(Guid OrganizationId, Guid RootId, Models.Request.Enums.OperationCanExecute operationCanExecute);
        [Get("/Organization/{OrganizationId}/CanExecute")]
        public Task<Guid> CheckRootOrganization(Guid OrganizationId, Models.Request.Enums.OperationCanExecute operationCanExecute);
        [Get("/Organization/{id}")]
        public Task<Models.Response.Organization> GetOrganization(Guid id);
        [Get("/Organization/Range/Roots/{RootId}")]
        public Task<ICollection<Models.Response.Organization>> GetOrganizations(Guid RootId, [Query] int offset, [Query] int count);
        [Get("/Organization/Range")]
        public Task<ICollection<Models.Response.Organization>> GetOrganizations([Query] int offset, [Query] int count);
        [Post("/Organization/")]
        public Task<Models.Response.Organization> CreateOrganization();
        [Put("/Organization/{id}/Info")]
        public Task<Models.Response.OrganizationInform> UpdateOrganizationInform(Guid id, Models.Request.UpdateOrganizationInform updateOrganizationInform);
        [Put("/Organization/{OrganizationId}/Logo")]
        public Task<Models.Response.ImageInfo> UpdateLogo(Guid OrganizationId, [Body] Models.Request.UpdateOrganizationLogo updateLogo);
        [Post("/Organization/{OrganizationId}/Images")]
        public Task<Models.Response.ImageInfo> AddImage(Guid OrganizationId, [Body] Models.Request.AddOrganizationImage addImage);
        [Put("/Organization/Images/{ImageId}")]
        public Task<Models.Response.ImageInfo> UpdateImage(Guid ImageId, [Body] Models.Request.UpdateOrganizationImage updateImage);
        [Delete("/Organization/{OrganizationId}/Image/Many")]
        public Task DeleteImages(Guid OrganizationId, [Body] Models.Request.DeleteOrganizationImages deleteImages);
        [Post("/Organization/{OrganizationId}/Members")]
        public Task<Models.Response.Member> AddOrganizationMember(Guid OrganizationId, Guid rootId);
        [Delete("/Organization/{OrganizationId}/Members/{MemberId}")]
        public Task RemoveOrganizationMember(Guid OrganizationId, Guid MemberId);
    }
}