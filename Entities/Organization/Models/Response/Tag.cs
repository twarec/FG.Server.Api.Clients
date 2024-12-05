using System;

namespace FG.Server.Api.Clients.Entities.Models.Response
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Value { get; set; } = "";
    }
}