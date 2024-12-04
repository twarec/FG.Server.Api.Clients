using System;

namespace FG.Server.Api.Clients.Entities.Organization.Models.Request
{
    public class DeleteOrganizationImages
    {
        public List<Guid> Ids { get; set; } = new List<Guid>();
    }
}