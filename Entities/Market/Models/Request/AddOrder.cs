using System;

namespace FG.Server.Api.Clients.Entities.Market.Models.Request
{
    public class AddOrder
    {
        public string Description { get; set; } = "";
        public Models.Responce.Address Address { get; set; } = new Models.Responce.Address();
        public ICollection<string> Tags { get; set; } = [];
        public ICollection<Models.Responce.OrderProductInfo> OrderProductsInfo { get; set; } = [];
    }
}