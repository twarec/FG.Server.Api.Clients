using FG.Server.Api.Clients.Entities.Event.Models.Request;
using Refit;

namespace FG.Server.Api.Clients.Entities.Event.Controllers
{
    public interface IBookingController
    {
        [Get("/Event/[Controller]/{BookingId}")]
        public Task<Models.Response.Booking> Get(Guid BookingId);
        [Get("/Event/[Controller]/Range/Event/{EventId}")]
        public Task<ICollection<Models.Response.Booking>> GetByEvent(Guid EventId, [Query] int offset, [Query] int count);
        [Get("/Event/[Controller]/Range/User/{UserId}")]
        public Task<ICollection<Models.Response.Booking>> GetByUser(Guid UserId, [Query] int offset, [Query] int count);
        [Get("/Event/[Controller]/Range/Organization/{OrganizationId}")]
        public Task<ICollection<Models.Response.Booking>> GetByOrganization(Guid OrganizationId, [Query] int offset, [Query] int count);
        [Post("/Event/[Controller]/{EventId}")]
        public Task<Models.Response.Booking> Add(Guid EventId, [Body] AddBooking addBooking);
        [Put("/Event/Organization/[Controller]/{BookingId}/Status")]
        public Task OrganizationUpdateStatus(Guid BookingId, [Query] Models.Response.Enums.BookingStatus status);
        [Put("/Event/User/[Controller]/{BookingId}/Status")]
        public Task UserUpdateStatus(Guid BookingId, [Query] Models.Response.Enums.BookingStatus status);
    }
}