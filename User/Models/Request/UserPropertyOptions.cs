using Refit;

namespace FG.Server.Api.Clients.User.Models.Request
{
	public class UserPropertyOptions
	{
		[Query]
		public Guid UserId { get; set; }
		[Query]
		public string StackName { get; set; } = string.Empty;
		[Query]
		public List<string> Keys { get; set; } = [];
	}
}
