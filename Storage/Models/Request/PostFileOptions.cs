namespace FG.Server.Api.Clients.Storage.Models.Request;

public class PostFileOptions
{
	public string Name { get; set; } = string.Empty;
	public string Extension { get; set; } = string.Empty; //.jpg, .pgg, ...
	public string File { get; set; } = string.Empty; //Base64
	public string Group { get; set; } = string.Empty; //UserAvatar, ...
	public string Description { get; set; } = string.Empty;
	public Dictionary<string, string> Metadata { get; set; } = [];
	public FileContentType Type { get; set; }
}

public enum FileContentType
{
	Binary, //In bd
	File, //file system
	Document, //In bd
}
