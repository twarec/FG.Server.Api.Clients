using System;

namespace FG.Server.Api.Clients.Entities.Event.Models.Response
{
    public class WorkTime
    {
        public Guid Id { get; set; }
        public long DateStart { get; set; }
        public long DateEnd { get; set; }
    }
}