using System;

namespace FG.Server.Api.Clients.Entities.Event.Models.Request
{
    public class UpdateEventDesctiprion
    {
        public List<Models.Responce.DesctiprionModel> Desctiprions { get; set; } = new List<Models.Responce.DesctiprionModel>();
    }
}