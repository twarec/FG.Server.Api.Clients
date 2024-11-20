using System;

namespace FG.Server.Api.Clients.Entities.Organization.Models.Responce
{
    public class OrganizationInform
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
    }
}