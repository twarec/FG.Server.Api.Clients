using FG.Server.Api.Clients.User.Models.Responce.User;

namespace FG.Server.Api.Clients.User.Models.Responce.Authorization;

public class AuthorizateResponce
{
    public UserResponce User { get; set; } = new();
    public string JwtToken { get; set; } = string.Empty;
    public Guid? SessionId { get; set; }
}
