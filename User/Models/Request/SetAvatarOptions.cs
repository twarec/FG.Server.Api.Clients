namespace FG.Server.Api.Clients.User.Models.Request
{
	public class SetAvatarOptions
	{
		public Guid UserId { get; set; }
		public string Avatar { get; set; } = string.Empty;
		public string Extension { get; set; } = string.Empty;
	}
}
