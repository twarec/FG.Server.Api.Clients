using System;

namespace FG.Server.Api.Clients.Entities.Event.Models.Request
{
    public class UpdateEventTags
    {
        public List<string> Tags { get; set; } = new List<string>();
    }
}