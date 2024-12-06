using System;

namespace FG.Server.Api.Clients.Entities.Event.Models.Response
{
    public class ImageInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Image { get; set; } = "";
    }
}