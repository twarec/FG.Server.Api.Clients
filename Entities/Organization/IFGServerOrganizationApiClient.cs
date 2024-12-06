using System;
using FG.Server.Api.Clients.Entities.Organization.Controllers;

namespace FG.Server.Api.Clients.Entities.Organization
{
    public interface IFGServerOrganizationApiClient
    {
        public IAccountController AccountController { get; }
        public IMembersController MembersController { get; }
        public IOrganizationController OrganizationController { get; }
        public IRootsController RootsController { get; }
    }
}