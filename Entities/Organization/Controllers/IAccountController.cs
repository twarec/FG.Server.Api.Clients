using Refit;

namespace FG.Server.Api.Clients.Entities.Organization.Controllers
{
    public interface IAccountController
    {
        [Get("/Organization/Account/Token")]
        public Task<string> TokenAsync([Query] string acesstoken);
        [Get("/Organization/Account/GenerateToken")]
        public Task<string> GenerateToken(string id);
    }
}