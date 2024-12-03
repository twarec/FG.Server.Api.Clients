using System;

namespace FG.Server.Organization.Api.Client.Models.Responce
{
    public class OrganizationInform
    {
        public Guid Id { get; set; }
        public String Name { get; set; } =  "" ;
        public String Description { get; set; } =  "" ;
        public ICollection<Models.Responce.ImageInfo> ImagesInfo { get; set; } = [];
    }
}