namespace FG.Server.Api.Clients.Storage.Models.Responce;

public record class FileGroupResponce
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
}

