namespace FG.Server.Api.Clients.Entities.Organization.Models.Responce
{
	public class Member
	{
		public Guid Id { get; set; }
		public Responce.Enums.MemberStatus MemberStatus { get; set; }
		public Responce.Enums.MemberFlags MemberFlags { get; set; }
		public Responce.MemberInform MemberInform { get; set; } = new Responce.MemberInform();
		public ICollection<Responce.MemberTag> Tags { get; set; } = [];
	}
}