namespace FG.Server.Api.Clients.User.Models.Responce;

public class AuthorizateAppleResponce : AuthorizateResponce
{
    public string AppleKey { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public bool VerifiedEmail { get; set; } = false;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

}
