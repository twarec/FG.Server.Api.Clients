namespace FG.Server.Api.Clients.Entities.Market.Models.Responce
{
	public class DeliverySettings
	{
		public Guid Id { get; set; }
		public long MaximumDeliveryTime { get; set; }
		public long MaximumDeliveryDistance { get; set; }
		public Responce.Price DeliveryPrice { get; set; } = new Responce.Price();
	}
}