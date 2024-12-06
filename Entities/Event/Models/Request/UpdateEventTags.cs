using System;

namespace FG.Server.Api.Clients.Entities.Models.Request
{
    public class UpdateEventTags
    {
        public List<string> Tags { get; set; } = new List<string>();
    }
}