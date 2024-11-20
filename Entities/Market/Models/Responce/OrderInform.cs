using System;

namespace FG.Server.Api.Clients.Entities.Market.Models.Responce
{
    public class OrderInform
    {
        public Guid Id { get; set; }
        public string Description { get; set; } = "";
        public Address Address { get; set; } = new Address();
        public ICollection<Responce.Tag> Tags { get; set; } = [];
        public ICollection<Responce.OrderProduct> Products { get; set; } = [];
    }
}