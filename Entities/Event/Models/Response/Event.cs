using System;

namespace FG.Server.Api.Clients.Entities.Models.Response
{
    public class Event
    {
        public Guid Id { get; set; }
        public Guid OrganizationId { get; set; }
        public Response.Enums.EventStatus Status { get; set; }
        public Response.EventInform EventInform { get; set; } = new Response.EventInform();
        public ICollection<Booking> Bookings { get; set; } = [];
        public ICollection<Response.Member> Members { get; set; } = [];
    }
}