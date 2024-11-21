namespace FG.Server.Api.Clients.Storage.Models.Responce;

public class FileContentResponce
{
	public Guid Id { get; set; }
	public string Data { get; set; } = string.Empty;
	public long DateCreate { get; set; } = DateTime.UtcNow.ToBinary();
	public long DateUpdate { get; set; } = DateTime.UtcNow.ToBinary();
}