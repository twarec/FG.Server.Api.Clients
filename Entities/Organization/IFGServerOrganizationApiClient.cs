using System;
using FG.Server.Organization.Api.Client.Controllers;

namespace FG.Server.Organization.Api.Client
{
    public interface IFGServerOrganizationApiClient
    {
        public IAccountController AccountController { get; }
        public IMembersController MembersController { get; }
        public IOrganizationController OrganizationController { get; }
    }
}