namespace FG.Server.Api.Clients.Admin.Models.Responce
{
	public class UserAuthorizateResponce
	{
		public int Id { get; set; }
		public string Email { get; set; } = string.Empty;
		public string FirstName { get; set; } = string.Empty;
		public string MiddleName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public UserRole Role { get; set; } = UserRole.Moderator;
		public bool IsConnect { get; set; }
		public Session Session { get; set; } = new();
		public List<ServerConfigurations> Servers { get; set; } = [];

	}

	public class Session
	{
		public int Id { get; set; }
		public DateTime DateCreate { get; set; }
	}

	public class ServerConfigurations
	{
		public string Name { get; set; } = string.Empty;
		public string Url { get; set; } = string.Empty;
		public string Token { get; set; } = string.Empty;
	}
}
