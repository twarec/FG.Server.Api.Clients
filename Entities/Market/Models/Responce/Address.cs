using System;

namespace FG.Server.Api.Clients.Entities.Market.Models.Responce
{
    public class Address
    {
        public string Data { get; set; } = "";
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}