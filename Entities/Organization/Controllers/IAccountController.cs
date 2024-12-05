using Refit;

namespace FG.Server.Api.Clients.Entities.Controllers
{
    public interface IAccountController
    {
        [Get("/Organization/Account/Token/{rootKey}")]
        public Task<string> TokenAsync(string rootKey, [Query] string accessTokens);
    }
}