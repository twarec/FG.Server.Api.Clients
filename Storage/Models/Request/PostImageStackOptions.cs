namespace FG.Server.Api.Clients.Storage.Models.Request;

public class PostImageStackOptions
{
	public PostFileOptions? File { get; set; }
	public Dictionary<string, ImageTransform> Transformations { get; set; } = [];
}