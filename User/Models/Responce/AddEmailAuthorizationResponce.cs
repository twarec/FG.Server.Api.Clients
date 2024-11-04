namespace FG.Server.Api.Clients.User.Models.Responce;

public class AddEmailAuthorizationResponce : AddAuthorizationResponce
{
    public string Email { get; set; } = string.Empty;
    public bool VerifiedEmail { get; set; } = false;
}
