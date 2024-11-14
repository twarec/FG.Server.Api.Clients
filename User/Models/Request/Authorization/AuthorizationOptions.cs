using Refit;

namespace FG.Server.Api.Clients.User.Models.Request.Authorization;

public class AuthorizationOptions
{
    [Query]
    public string Platform { get; set; } = string.Empty;
    [Query]
    public string Application { get; set; } = string.Empty;
    [Query]
    public string ApplicationVersion { get; set; } = string.Empty;
}
