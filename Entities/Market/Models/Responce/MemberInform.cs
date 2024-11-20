using System;

namespace FG.Server.Api.Clients.Entities.Market.Models.Responce
{
    public class MemberInform
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public ICollection<Responce.Tag> Tags { get; set; } = [];
    }
}