namespace FG.Server.Api.Clients.Entities.Event.Models.Responce
{
	public class EventInform
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = "";
		public string Description { get; set; } = "";
		public Responce.ImageInfo Logo { get; set; } = new Responce.ImageInfo();
		public Responce.Price Price { get; set; } = new Responce.Price();
		public Responce.WorkTime WorkTime { get; set; } = new Responce.WorkTime();
		public Address Address { get; set; } = new Address();
		public Responce.PlacesInfo PlacesInfo { get; set; } = new Responce.PlacesInfo();
		public ICollection<Responce.Tag> Tags { get; set; } = [];
		public ICollection<Responce.ImageInfo> ImagesInfo { get; set; } = [];
		public ICollection<Description> Descriptions { get; set; } = [];
	}
}