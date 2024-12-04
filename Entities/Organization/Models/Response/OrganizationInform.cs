using System;

namespace FG.Server.Api.Clients.Entities.Organization.Models.Response
{
    public class OrganizationInform
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public ICollection<ImageInfo> ImagesInfo { get; set; } = [];
    }
}