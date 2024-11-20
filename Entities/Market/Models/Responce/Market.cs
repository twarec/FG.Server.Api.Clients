using System;

namespace FG.Server.Api.Clients.Entities.Market.Models.Responce
{
    public class Market
    {
        public Guid Id { get; set; }
        public Guid OrganizationId { get; set; }
        public Responce.Enums.MarketStatus Status { get; set; }
        public Responce.Enums.MarketState State { get; set; }
        public Responce.MarketInfo MarketInfo { get; set; } = new Responce.MarketInfo();
        public ICollection<Responce.Order> Orders { get; set; } = [];
        public ICollection<Responce.Member> Members { get; set; } = [];
        public Catalog Catalog { get; set; } = new Catalog();
    }
}