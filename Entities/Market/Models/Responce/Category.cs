namespace FG.Server.Api.Clients.Entities.Market.Models.Responce
{
	public class Category
	{
		public Guid Id { get; set; }
		public int NumberInQueue { get; set; }
		public Responce.CategoryInform CategoryInform { get; set; } = new Responce.CategoryInform();
		public ICollection<Responce.Product> Products { get; set; } = [];
	}
}