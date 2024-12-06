using System;

namespace FG.Server.Api.Clients.Entities.Event.Models.Request
{
    public class DeleteEventImages
    {
        public List<Guid> Ids { get; set; } = new List<Guid>();
    }
}