using Refit;

namespace FG.Server.Organization.Api.Client.Controllers
{
    public interface IAccountController
    {
        [Get("/Main/Account/Token/{rootKey}")]
        public Task<String> TokenAsync(String rootKey, [Query] String accessTokens);
    }
}