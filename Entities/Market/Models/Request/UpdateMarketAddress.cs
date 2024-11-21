using System;

namespace FG.Server.Api.Clients.Entities.Market.Models.Request
{
    public class UpdateMarketAddress
    {
        public string Data { get; set; } = "";
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}