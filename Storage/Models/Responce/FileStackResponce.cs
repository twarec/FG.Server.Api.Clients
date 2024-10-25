namespace FG.Server.Api.Clients.Storage.Models.Responce;

public record class FileStackResponce
{
    public Guid Id { get; set; }
    public long Lenght { get; set; }
    public DateTime DateCreate { get; set; } = DateTime.UtcNow;
    public DateTime DateUpdate { get; set; } = DateTime.UtcNow;

    public Dictionary<string, FileResponce> Files { get; set; } = [];
    public Dictionary<string, string> Metadata { get; set; } = [];
}
