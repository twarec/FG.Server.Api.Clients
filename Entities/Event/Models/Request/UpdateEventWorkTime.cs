using System;

namespace FG.Server.Api.Clients.Entities.Models.Request
{
    public class UpdateEventWorkTime
    {
        public ulong DateStart { get; set; }
        public ulong DateEnd { get; set; }
    }
}