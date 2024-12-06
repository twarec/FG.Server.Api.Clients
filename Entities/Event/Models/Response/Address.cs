using System;

namespace FG.Server.Api.Clients.Entities.Models.Response
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Data { get; set; } = "";
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}