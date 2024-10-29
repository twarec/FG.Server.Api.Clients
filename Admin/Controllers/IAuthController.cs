using FG.Server.Api.Clients.Admin.Models.Request;
using FG.Server.Api.Clients.Admin.Models.Responce;
using Refit;

namespace FG.Server.Api.Clients.Admin.Controllers
{
    public interface IAuthController
    {
        [Post("/api/Auth/Registration")]
        public Task<UserAuthorizateResponce> RegestrationAsync([Body] RegistrationOptions options);

        [Post("/api/Auth/Authorization")]
        public Task<UserAuthorizateResponce> AuthorizationAsync([Body] AuthotizationOptions options);

        [Post("/api/Auth/Authorization/Session")]
        public Task<UserAuthorizateResponce> AuthorizationSessionAsync([Body]int sessionId);
    }
}
