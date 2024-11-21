using System;

namespace FG.Server.Api.Clients.Entities.Event.Models.Request
{
    public class UpdateEventWorkTime
    {
        public long DayStart { get; set; }
        public long MinuteStart { get; set; }
        public long DayEnd { get; set; }
        public long MinuteEnd { get; set; }
    }
}