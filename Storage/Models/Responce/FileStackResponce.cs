namespace FG.Server.Api.Clients.Storage.Models.Responce;

public record class FileStackResponce
{
    public Guid Id { get; set; }
    public long Lenght { get; set; }
    public long DateCreate { get; set; } = DateTime.UtcNow.ToBinary();
    public long DateUpdate { get; set; } = DateTime.UtcNow.ToBinary();

    public Dictionary<string, FileResponce> Files { get; set; } = [];
    public Dictionary<string, string> Metadata { get; set; } = [];
}
