using System;

namespace FG.Server.Api.Clients.Entities.Organization.Models.Response
{
    public class Organization
    {
        public Guid Id { get; set; }
        public Response.Enums.OrganizationStatus OrganizationStatus { get; set; }
        public Response.OrganizationInform OrganizationInform { get; set; } = new Response.OrganizationInform();
        public ICollection<Member> Members { get; set; } = [];
    }
}