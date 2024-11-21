using System;

namespace FG.Server.Api.Clients.Entities.Market.Models.Request
{
    public class UpdateMarketTags
    {
        public List<string> Tags { get; set; } = new List<string>();
    }
}