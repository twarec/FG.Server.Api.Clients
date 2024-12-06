using System;

namespace FG.Server.Api.Clients.Entities.Event.Models.Request
{
    public class UpdateEventDescription
    {
        public List<Models.Response.DescriptionModel> Descriptions { get; set; } = new List<Models.Response.DescriptionModel>();
    }
}