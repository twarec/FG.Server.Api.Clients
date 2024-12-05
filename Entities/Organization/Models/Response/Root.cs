using System;

namespace FG.Server.Api.Clients.Entities.Models.Response
{
    public class Root
    {
        public Guid Id { get; set; }
        public string Key { get; set; } = "";
        public string Server { get; set; } = "";
        public string ServerKey { get; set; } = "";
    }
}