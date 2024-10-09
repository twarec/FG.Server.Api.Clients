using System.Text.Json.Serialization;

namespace FG.Server.Api.Clients.Main.Models.Responce.Map;

public class UserMarkerValue
{
    public string UserId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Avatar { get; set; } = string.Empty;
    public string ShapeAvatar { get; set; } = string.Empty;
    public string TagLanguage { get; set; } = string.Empty;
    public string Subscription { get; set; } = string.Empty;
    public float Score { get; set; }
    public long Birth { get; set; } = DateTime.Now.ToBinary();
}
