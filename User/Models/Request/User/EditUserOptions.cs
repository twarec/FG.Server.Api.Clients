namespace FG.Server.Api.Clients.User.Models.Request.User;

public class EditUserOptions
{
	public long DateBirth { get; set; } = 0;

	public string DisplayName { get; set; } = string.Empty;
	public string PhoneNumber { get; set; } = string.Empty;

	public string FirstName { get; set; } = string.Empty;
	public string MiddleName { get; set; } = string.Empty;
	public string LastName { get; set; } = string.Empty;

}
