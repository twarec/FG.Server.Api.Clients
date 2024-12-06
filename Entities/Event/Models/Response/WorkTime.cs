using System;

namespace FG.Server.Api.Clients.Entities.Event.Models.Response
{
    public class WorkTime
    {
        public Guid Id { get; set; }
        public ulong DateStart { get; set; }
        public ulong DateEnd { get; set; }
    }
}