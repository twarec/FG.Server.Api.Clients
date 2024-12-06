using System;

namespace FG.Server.Api.Clients.Entities.Event.Models.Request
{
    public class UpdateEventWorkTime
    {
        public long DateStart { get; set; }
        public long DateEnd { get; set; }
    }
}