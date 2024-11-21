namespace FG.Server.Api.Clients.User.Models.Responce.User;

public class UserResponce
{
	public Guid Id { get; set; }
	public Guid AvatarId { get; set; }

	public bool VerifiedEmail { get; set; } = false;
	public long DateBirth { get; set; } = DateTime.UtcNow.ToBinary();
	public string Language { get; set; } = string.Empty;
	public string DisplayName { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
	public string PhoneNumber { get; set; } = string.Empty;

	public long DateUpdate { get; set; } = DateTime.UtcNow.ToBinary();

	public Dictionary<string, object> AdditionalModels { get; set; } = [];
}
