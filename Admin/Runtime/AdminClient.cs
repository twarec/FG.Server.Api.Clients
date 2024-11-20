using FG.Server.Api.Clients.Admin.Controllers;
using Refit;

namespace FG.Server.Api.Clients.Admin.Runtime
{
    public class AdminClient(HttpClient httpClient) : IAdminClient
    {
        public string BaseUri => httpClient.BaseAddress?.AbsoluteUri ?? string.Empty;
        public IAuthController AuthController { get; } = RestService.For<IAuthController>(httpClient);
        public IClaimController ClaimController { get; } = RestService.For<IClaimController>(httpClient);
        public IModerationController ModerationController { get; } = RestService.For<IModerationController>(httpClient);
        public IModerationUserController ModerationUserController { get; } = RestService.For<IModerationUserController>(httpClient);
        public IUserController UserController { get; } = RestService.For<IUserController>(httpClient);
    }
}
