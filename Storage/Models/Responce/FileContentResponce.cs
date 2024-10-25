namespace FG.Server.Api.Clients.Storage.Models.Responce;

public class FileContentResponce
{
    public Guid Id { get; set; }
    public string Data { get; set; } = string.Empty;
    public DateTime DateCreate { get; set; } = DateTime.UtcNow;
    public DateTime DateUpdate { get; set; } = DateTime.UtcNow;
}