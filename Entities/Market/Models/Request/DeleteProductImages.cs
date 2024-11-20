using System;

namespace FG.Server.Api.Clients.Entities.Market.Models.Request
{
    public class DeleteProductImages
    {
        public List<Guid> Ids { get; set; } = new List<Guid>();
    }
}