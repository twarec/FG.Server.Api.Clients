using System;

namespace FG.Server.Api.Clients.Entities.Models.Response
{
    public class MemberInform
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public ICollection<Response.Tag> Tags { get; set; } = [];
    }
}