namespace FG.Server.Api.Clients.User.Models.Responce.Authorization;

public class AuthorizateEmailResponce : AuthorizateResponce
{
	public string Email { get; set; } = string.Empty;
	public bool VerifiedEmail { get; set; } = false;
}
