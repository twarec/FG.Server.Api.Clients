using System;

namespace FG.Server.Api.Clients.Entities.Event.Models.Responce
{
    public class Price
    {
        public Guid Id { get; set; }
        public ulong Amount { get; set; }
        public string Currency { get; set; } = "";
    }
}