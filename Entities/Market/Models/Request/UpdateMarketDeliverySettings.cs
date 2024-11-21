using System;

namespace FG.Server.Api.Clients.Entities.Market.Models.Request
{
    public class UpdateMarketDeliverySettings
    {
        public long MaximumDeliveryTime { get; set; }
        public long MaximumDeliveryDistance { get; set; }
        public Models.Responce.Price Price { get; set; } = new Models.Responce.Price();
    }
}