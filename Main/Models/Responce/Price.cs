namespace FG.Server.Api.Clients.Main.Models.Responce;

public record class Price
{
	public float Ammount { get; set; }
	public string Currency { get; set; } = string.Empty;
}
