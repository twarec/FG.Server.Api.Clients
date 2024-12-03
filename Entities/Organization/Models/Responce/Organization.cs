using System;

namespace FG.Server.Organization.Api.Client.Models.Responce
{
    public class Organization
    {
        public Guid Id { get; set; }
        public Models.Responce.Enums.OrganizationStatus OrganizationStatus { get; set; }
        public Models.Responce.OrganizationInform OrganizationInform { get; set; } = new Models.Responce.OrganizationInform();
        public ICollection<Models.Responce.Member> Members { get; set; } = [];
    }
}