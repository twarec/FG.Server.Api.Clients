using FG.Server.Api.Clients.Storage.Models.Request;

namespace FG.Server.Api.Clients.Storage.Models.Responce;

public record class FileStructureResponce
{
    public Guid Id { get; set; }
    public Guid FileId { get; set; }
    public long Lenght { get; set; }
    public DateTime DateCreate { get; set; } = DateTime.UtcNow;
    public DateTime DateUpdate { get; set; } = DateTime.UtcNow;
    public FileContentType Type { get; set; }
}
