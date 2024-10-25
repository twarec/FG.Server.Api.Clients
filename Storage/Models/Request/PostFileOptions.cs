namespace FG.Server.Api.Clients.Storage.Models.Request;

public class PostFileOptions
{
    public string Name { get; set; } = string.Empty;
    public string Extension { get; set; } = string.Empty;
    public string File { get; set; } = string.Empty;
    public string Group { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Dictionary<string, string> Metadata { get; set; } = [];
    public FileContentType Type { get; set; }
}

public enum FileContentType
{
    Binary,
    File,
    Document,
}
