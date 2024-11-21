namespace FG.Server.Api.Clients.Storage.Models.Responce;

public class ConfigurateResponce
{
	public Guid Id { get; set; }

	public string Name { get; set; } = string.Empty;

	public long DateCreate { get; set; } = DateTime.UtcNow.ToBinary();
	public long DateUpdate { get; set; } = DateTime.UtcNow.ToBinary();

	public List<ConfigurateFileResponce> Files { get; set; } = [];
}
