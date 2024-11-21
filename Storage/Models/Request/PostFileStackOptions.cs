namespace FG.Server.Api.Clients.Storage.Models.Request;

public class PostFileStackOptions
{
	public Dictionary<string, string> Metadata { get; set; } = [];
	public Dictionary<string, PostFileOptions> Files { get; set; } = [];
}
