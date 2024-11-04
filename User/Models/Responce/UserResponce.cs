namespace FG.Server.Api.Clients.User.Models.Responce;

public class UserResponce
{
	public Guid Id { get; set; }

	public string FirstName { get; set; } = string.Empty;
	public string MiddleName { get; set; } = string.Empty;
	public string LastName { get; set; } = string.Empty;
	public DateTime Brith { get; set; } = DateTime.UtcNow;
	public string Login { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
	public string PhoneNumber { get; set; } = string.Empty;

	public DateTime DateUpdate { get; set; } = DateTime.UtcNow;
}
