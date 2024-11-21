namespace FG.Server.Api.Clients.Entities.Market.Models.Responce
{
	public class OrderProduct
	{
		public Guid Id { get; set; }
		public Guid ProductId { get; set; }
		public int Count { get; set; }
	}
}