namespace FG.Server.Api.Clients.Entities.Organization.Models.Responce
{
	public class Organization
	{
		public Guid Id { get; set; }
		public Responce.Enums.OrganizationStatus OrganizationStatus { get; set; }
		public Responce.OrganizationInform OrganizationInform { get; set; } = new Responce.OrganizationInform();
		public ICollection<Member> Members { get; set; } = [];
		public ICollection<ImageInfo> ImagesInfo { get; set; } = [];
	}
}