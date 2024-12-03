using System;
using FG.Server.Organization.Api.Client.Controllers;

namespace FG.Server.Organization.Api.Client.Runtime
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