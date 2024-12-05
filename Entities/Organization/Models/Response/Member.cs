using System;

namespace FG.Server.Api.Clients.Entities.Organization.Models.Response
{
    public class Member
    {
        public Guid Id { get; set; }
        public Guid RootId { get; set; }
        public Response.Enums.MemberStatus MemberStatus { get; set; }
        public Response.Enums.MemberFlags MemberFlags { get; set; }
        public Response.MemberInform MemberInform { get; set; } = new Response.MemberInform();
        public ICollection<Response.Tag> Tags { get; set; } = [];
        public Response.Root Root { get; set; } = new Response.Root();
    }
}