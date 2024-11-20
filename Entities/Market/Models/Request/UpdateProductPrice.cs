using System;

namespace FG.Server.Api.Clients.Entities.Market.Models.Request
{
    public class UpdateProductPrice
    {
        public ulong Amount { get; set; }
        public string Currency { get; set; } = "";
    }
}