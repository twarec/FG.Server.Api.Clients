using Refit;

namespace FG.Server.Api.Clients.User.Models.Request.User
{
	public class UserPropertyOptions
	{
		[Query]
		public string StackName { get; set; } = string.Empty;
		[Query]
		public List<string> Keys { get; set; } = [];
	}
}
