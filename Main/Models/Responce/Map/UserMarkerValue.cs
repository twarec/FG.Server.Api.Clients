namespace FG.Server.Api.Clients.Main.Models.Responce.Map;

public record class UserMarkerValue
{
    public string UserId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Avatar { get; set; } = string.Empty;
    public string ShapeAvatar { get; set; } = string.Empty;
    public string Subscription { get; set; } = string.Empty;
    public string? TagLanguage { get; set; }
    public float Score { get; set; }
    public long Birth { get; set; } = DateTime.Now.ToBinary();
}
