using System;

namespace FG.Server.Api.Clients.Entities.Event.Models.Response
{
    public class Description
    {
        public Guid Id { get; set; }
        public string Type { get; set; } = "";
        public string DescriptionData { get; set; } = "";
    }
}