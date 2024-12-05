using System;
using FG.Server.Api.Clients.Entities.Organization.Controllers;

namespace FG.Server.Api.Clients.Entities.Organization.Runtime
{
    public class FGServerOrganizationApiClient : IFGServerOrganizationApiClient
    {
        private static HttpClient? _client;
        public IAccountController AccountController { get; }
        public IMembersController MembersController { get; }
        public IOrganizationController OrganizationController { get; }

        public FGServerOrganizationApiClient(HttpClient client)
        {
            _client = client;
            AccountController = Refit.RestService.For<IAccountController>(_client);
            MembersController = Refit.RestService.For<IMembersController>(_client);
            OrganizationController = Refit.RestService.For<IOrganizationController>(_client);
        }
    }
}