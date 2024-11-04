using Refit;

namespace FG.Server.Api.Clients.User.Models.Request;

public class AuthorizationEmailOptions : AuthorizationOptions
{
    [Query]
    public string Email { get; set; } = string.Empty;
    [Query]
    public string Password { get; set; } = string.Empty;
}
