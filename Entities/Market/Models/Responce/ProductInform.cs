namespace FG.Server.Api.Clients.Entities.Market.Models.Responce
{
	public class ProductInform
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = "";
		public string Description { get; set; } = "";
		public int Count { get; set; }
		public Price Price { get; set; } = new Price();
		public Characteristics Characteristics { get; set; } = new Characteristics();
		public ICollection<ImageInfo> Images { get; set; } = [];
		public ICollection<Responce.Tag> Tags { get; set; } = [];
	}
}