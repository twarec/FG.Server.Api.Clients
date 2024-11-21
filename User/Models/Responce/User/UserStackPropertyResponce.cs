namespace FG.Server.Api.Clients.User.Models.Responce.User
{
	public class UserStackPropertyResponce
	{
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;

		public List<UserPropertyResponce> Properties { get; set; } = [];
	}
}
