namespace FG.Server.Api.Clients.Storage.Models.Responce;

public record class FileInfromResponce
{
    public Guid Id { get; set; }
    public long DateCreate { get; set; } = DateTime.UtcNow.ToBinary();
    public long DateUpdate { get; set; } = DateTime.UtcNow.ToBinary();
    public string Name { get; set; } = string.Empty;
    public string Extension { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}