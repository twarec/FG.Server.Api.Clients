using System;

namespace FG.Server.Organization.Api.Client.Models.Responce
{
    public class Member
    {
        public Guid Id { get; set; }
        public Models.Responce.Enums.MemberStatus MemberStatus { get; set; }
        public Models.Responce.Enums.MemberFlags MemberFlags { get; set; }
        public Models.Responce.MemberInform MemberInform { get; set; } = new Models.Responce.MemberInform();
        public ICollection<Models.Responce.Tag> Tags { get; set; } = [];
    }
}