using System;

namespace FG.Server.Api.Clients.Entities.Models.Response
{
    public class Booking
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid EventId { get; set; }
        public Response.Enums.BookingStatus Status { get; set; }
        public Response.BookingInform BookingInform { get; set; } = new Response.BookingInform();
        public Response.Event Event { get; set; } = new Response.Event();
    }
}