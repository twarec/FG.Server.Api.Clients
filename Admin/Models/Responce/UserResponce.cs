namespace FG.Server.Api.Clients.Admin.Models.Responce
{
	public class UserResponce
	{
		public int Id { get; set; }
		public string Email { get; set; } = string.Empty;
		public string FirstName { get; set; } = string.Empty;
		public string MiddleName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public UserRole Role { get; set; } = UserRole.Moderator;
		public bool IsConnect { get; set; }
	}
}
