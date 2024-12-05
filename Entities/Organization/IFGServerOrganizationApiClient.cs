using System;
using FG.Server.Api.Clients.Entities.Controllers;

namespace FG.Server.Api.Clients.Entities
{
    public interface IFGServerOrganizationApiClient
    {
        public IAccountController AccountController { get; }
        public IMembersController MembersController { get; }
        public IOrganizationController OrganizationController { get; }
    }
}