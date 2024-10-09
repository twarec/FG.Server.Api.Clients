namespace FG.Server.Api.Clients.Main.Models.Responce.Map;

public record class EventMarkerValue
{
    public string EventId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Banner { get; set; } = string.Empty;

    public Price Price { get; set; } = new();
    public UserMarkerValue User { get; set; } = new();
    public DateTimeRange TimeRange { get; set; } = new();

    public List<string> Tags { get; set; } = [];
}
