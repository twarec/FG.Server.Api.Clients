using Refit;

namespace FG.Server.Api.Clients.Entities.Event.Controllers
{
    public interface IBookingController
    {
        [Get("/Event/[Controller]/{BookingId}")]
        public Task<Models.Responce.Booking> Get(Guid BookingId);
        [Get("/Event/[Controller]/Range/Event/{EventId}")]
        public Task<ICollection<Models.Responce.Booking>> GetByEvent(Guid EventId, [Query] int offset, [Query] int count);
        [Get("/Event/[Controller]/Range/User/{UserId}")]
        public Task<ICollection<Models.Responce.Booking>> GetByUser(Guid UserId, [Query] int offset, [Query] int count);
        [Get("/Event/[Controller]/Range/Organization/{OrganizationId}")]
        public Task<ICollection<Models.Responce.Booking>> GetByOrganization(Guid OrganizationId, [Query] int offset, [Query] int count);
        [Post("/Event/[Controller]/{EventId}")]
        public Task<Models.Responce.Booking> Add(Guid EventId, [Body] Models.Request.AddBooking addBooking);
        [Put("/Event/Organization/[Controller]/{BookingId}/Status")]
        public Task<Models.Responce.Booking> OrganizationUpdateStatus(Guid BookingId, [Query] Models.Responce.Enums.BookingStatus status);
        [Put("/Event/User/[Controller]/{BookingId}/Status")]
        public Task<Models.Responce.Booking> UserUpdateStatus(Guid BookingId, [Query] Models.Responce.Enums.BookingStatus status);
    }
}