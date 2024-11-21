namespace FG.Server.Api.Clients.Entities.Market.Models.Responce
{
	public class Catalog
	{
		public Guid Id { get; set; }
		public ICollection<Responce.Category> Categorys { get; set; } = [];
	}
}