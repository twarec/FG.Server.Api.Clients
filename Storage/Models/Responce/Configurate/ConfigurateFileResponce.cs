namespace FG.Server.Api.Clients.Storage.Models.Responce;

public class ConfigurateFileResponce
{
    public Guid Id { get; set; }

    public long DateCreate { get; set; } = DateTime.UtcNow.ToBinary();
    public long DateUpdate { get; set; } = DateTime.UtcNow.ToBinary();

    public Dictionary<string, string> Metadata { get; set; } = [];

    public FileResponce? File { get; set; }
}
