using FG.Server.Api.Clients.Storage.Models.Request;

namespace FG.Server.Api.Clients.Storage.Models.Responce;

public record class FileStructureResponce
{
    public Guid Id { get; set; }
    public Guid FileId { get; set; }
    public long Lenght { get; set; }
    public long DateCreate { get; set; } = DateTime.UtcNow.ToBinary();
    public long DateUpdate { get; set; } = DateTime.UtcNow.ToBinary();
    public FileContentType Type { get; set; }
}
