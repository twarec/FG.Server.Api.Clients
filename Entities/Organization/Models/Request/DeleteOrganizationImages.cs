using System;

namespace FG.Server.Organization.Api.Client.Models.Request
{
    public class DeleteOrganizationImages
    {
        public List<Guid> Ids { get; set; } = new List<Guid>();
    }
}