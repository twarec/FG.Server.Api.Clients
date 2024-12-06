using System;

namespace FG.Server.Api.Clients.Entities.Models.Response
{
    public class ImageInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Image { get; set; } = "";
    }
}