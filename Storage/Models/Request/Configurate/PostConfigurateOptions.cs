namespace FG.Server.Api.Clients.Storage.Models.Request.Configurate;

public class PostConfigurateOptions
{
    public string Data { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public Dictionary<string, string> Metadata { get; set; } = [];
}
