using System;

namespace FG.Server.Api.Clients.Entities.Event.Models.Responce
{
    public class Booking
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Responce.Enums.BookingStatus Status { get; set; }
        public Responce.Event Event { get; set; } = new Responce.Event();
        public Responce.BookingInform BookingInform { get; set; } = new Responce.BookingInform();
    }
}