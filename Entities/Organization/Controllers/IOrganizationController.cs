using Refit;

namespace FG.Server.Organization.Api.Client.Controllers
{
    public interface IOrganizationController
    {
        [Get("/Organization/{OrganizationId}/Roots/{RootId}/CanExecute")]
        public Task<Guid> CheckRootOrganization(Guid OrganizationId, Guid RootId, Models.Request.Enums.OperationCanExecute operationCanExecute);
        [Get("/Organization/{OrganizationId}/CanExecute")]
        public Task<Guid> CheckRootOrganization(Guid OrganizationId, Models.Request.Enums.OperationCanExecute operationCanExecute);
        [Get("/Organization/{id}")]
        public Task<Models.Responce.Organization> GetOrganization(Guid id);
        [Get("/Organization/Range/Roots/{RootId}")]
        public Task<ICollection<Models.Responce.Organization>> GetOrganizations(Guid RootId, [Query] Int32 offset, [Query] Int32 count);
        [Get("/Organization/Range")]
        public Task<ICollection<Models.Responce.Organization>> GetOrganizations([Query] Int32 offset, [Query] Int32 count);
        [Post("/Organization/")]
        public Task<Models.Responce.Organization> CreateOrganization();
        [Put("/Organization/{id}/Info")]
        public Task<Models.Responce.Organization> UpdateOrganizationInform(Guid id, Models.Request.UpdateOrganizationInform updateOrganizationInform);
        [Post("/Organization/{OrganizationId}/Images")]
        public Task<Models.Responce.ImageInfo> AddImage(Guid OrganizationId, [Body] Models.Request.AddOrganizationImage addImage);
        [Put("/Organization/Images/{ImageId}")]
        public Task<Models.Responce.ImageInfo> UpdateImage(Guid ImageId, [Body] Models.Request.UpdateOrganizationImage updateImage);
        [Delete("/Organization/{OrganizationId}/Image/Many")]
        public Task DeleteImages(Guid OrganizationId, [Body] Models.Request.DeleteOrganizationImages deleteImages);
        [Post("/Organization/{OrganizationId}/Members")]
        public Task<Models.Responce.Organization> AddOrganizationMember(Guid OrganizationId, Guid rootId);
        [Delete("/Organization/{OrganizationId}/Members/{MemberId}")]
        public Task<Models.Responce.Organization> RemoveOrganizationMember(Guid OrganizationId, Guid MemberId);
    }
}