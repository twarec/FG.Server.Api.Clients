namespace FG.Server.Api.Clients.Storage.Models.Responce;

public record class FileResponce
{
    public Guid Id { get; set; }
    public Guid ContentId { get; set; }
    public Guid GroupId { get; set; }
    public Guid InformId { get; set; }

    public DateTime DateCreate { get; set; } = DateTime.UtcNow;
    public DateTime DateUpdate { get; set; } = DateTime.UtcNow;

    public string Link { get; set; } = string.Empty;

    public FileGroupResponce? Group { get; set; }
    public FileInfromResponce? Inform { get; set; }
    public FileContentResponce? Content { get; set; }
    public FileStructureResponce? Structure { get; set; }

    public Dictionary<string, string> Metadata { get; set; } = [];
}