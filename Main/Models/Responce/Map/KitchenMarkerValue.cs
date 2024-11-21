namespace FG.Server.Api.Clients.Main.Models.Responce.Map;

public record class KitchenMarkerValue
{
	public string KitchenId { get; set; } = string.Empty;
	public string Name { get; set; } = string.Empty;
	public string Banner { get; set; } = string.Empty;

	public UserMarkerValue User { get; set; } = new();

	public List<string> Tags { get; set; } = [];
}
