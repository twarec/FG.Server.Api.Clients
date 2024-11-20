using System;

namespace FG.Server.Api.Clients.Entities.Market.Models.Request
{
    public class UpdateProductInform
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int Count { get; set; }
    }
}