namespace FG.Server.Api.Clients.Storage.Models.Request;

public class PutContentOptions
{
	public Guid Id { get; set; }
	public string File { get; set; } = string.Empty;
}
