using System;

namespace FG.Server.Api.Clients.Entities.Market.Models.Responce
{
    public class Member
    {
        public Guid Id { get; set; }
        public Guid OrganizationMemberId { get; set; }
        public Responce.MemberInform MemberInform { get; set; } = new Responce.MemberInform();
    }
}