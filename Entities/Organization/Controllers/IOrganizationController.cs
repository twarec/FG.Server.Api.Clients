using Refit;

namespace FG.Server.Api.Clients.Entities.Organization.Controllers
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
		public Task<ICollection<Models.Responce.Organization>> GetOrganizations(Guid RootId, [Query] int offset, [Query] int count);
		[Get("/Organization/Range")]
		public Task<ICollection<Models.Responce.Organization>> GetOrganizations([Query] int offset, [Query] int count);
		[Post("/Organization/")]
		public Task<Models.Responce.Organization> CreateOrganization();
		[Put("/Organization/{id}/Info")]
		public Task<Models.Responce.Organization> UpdateOrganizationInform(Guid id, Models.Request.UpdateOrganizationInform updateOrganizationInform);
		[Post("/Organization/{OrganizationId}/Members")]
		public Task<Models.Responce.Organization> AddOrganizationMember(Guid OrganizationId, Guid rootId);
		[Delete("/Organization/{OrganizationId}/Members/{MemberId}")]
		public Task<Models.Responce.Organization> RemoveOrganizationMember(Guid OrganizationId, Guid MemberId);
	}
}