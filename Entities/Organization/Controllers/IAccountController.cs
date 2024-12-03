using Refit;

namespace FG.Server.Organization.Api.Client.Controllers
{
    public interface IAccountController
    {
        [Get("/Organization/Account/Token/{rootKey}")]
        public Task<String> TokenAsync(String rootKey, [Query] String accessTokens);
    }
}