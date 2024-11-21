using System;

namespace FG.Server.Api.Clients.Entities.Market.Models.Responce
{
    public class MarketInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public ImageInfo Logo { get; set; } = new ImageInfo();
        public Address Address { get; set; } = new Address();
        public ICollection<Responce.Tag> Tags { get; set; } = [];
        public DeliverySettings DeliverySettings { get; set; } = new DeliverySettings();
        public Responce.ServiceSettings ServiceSettings { get; set; } = new Responce.ServiceSettings();
    }
}