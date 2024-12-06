using System;

namespace FG.Server.Api.Clients.Entities.Event.Models.Response
{
    public class Member
    {
        public Guid Id { get; set; }
        public Guid OrganizationMemberId { get; set; }
        public Response.MemberInform MemberInform { get; set; } = new Response.MemberInform();
    }
}