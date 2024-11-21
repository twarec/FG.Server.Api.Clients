namespace FG.Server.Api.Clients.Entities.Market.Models.Responce
{
	public class Product
	{
		public Guid Id { get; set; }
		public int NumberInQueue { get; set; }
		public Responce.ProductInform ProductInform { get; set; } = new Responce.ProductInform();
	}
}