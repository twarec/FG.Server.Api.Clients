using System;

namespace FG.Server.Api.Clients.Entities.Models.Request
{
    public class UpdateEventPrice
    {
        public ulong Amount { get; set; }
        public string Currency { get; set; } = "";
    }
}