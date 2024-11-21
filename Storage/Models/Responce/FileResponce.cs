namespace FG.Server.Api.Clients.Storage.Models.Responce;

public record class FileResponce
{
    public Guid Id { get; set; }
    public Guid ContentId { get; set; }
    public Guid GroupId { get; set; }
    public Guid InformId { get; set; }

    public long DateCreate { get; set; } = DateTime.UtcNow.ToBinary();
    public long DateUpdate { get; set; } = DateTime.UtcNow.ToBinary();

    public string Link { get; set; } = string.Empty;
    public string Group { get; set; } = string.Empty;

    public FileInfromResponce? Inform { get; set; }
    public FileContentResponce? Content { get; set; }
    public FileStructureResponce? Structure { get; set; }

    public Dictionary<string, string> Metadata { get; set; } = [];
}