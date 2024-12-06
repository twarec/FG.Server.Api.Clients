using System;

namespace FG.Server.Api.Clients.Entities.Event.Models.Request
{
    public class UpdateEventImage
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Data { get; set; } = "";
    }
}