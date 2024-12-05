using System;

namespace FG.Server.Api.Clients.Entities.Organization.Models.Response
{
    public class OrganizationInform
    {
        public Guid Id { get; set; }
        public string DisplayName { get; set; } = "";
        public string DisplayDescription { get; set; } = "";
        public ImageInfo Logo { get; set; } = new ImageInfo();
        public ICollection<ImageInfo> ImagesInfo { get; set; } = [];
    }
}