namespace FG.Server.Api.Clients.User.Models.Responce.User;

public class AddGoogleAuthorizationResponce : AddAuthorizationResponce
{
	public string GoogleKey { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
	public string FirstName { get; set; } = string.Empty;
	public string LastName { get; set; } = string.Empty;
}
