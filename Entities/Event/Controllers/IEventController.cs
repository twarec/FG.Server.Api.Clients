using Refit;

namespace FG.Server.Api.Clients.Entities.Controllers
{
    public interface IEventController
    {
        [Get("/Event/{EventId}")]
        public Task<Models.Response.Event> Get(Guid EventId);
        [Get("/Event/Range/Organization/{OrganizationId}")]
        public Task<ICollection<Models.Response.Event>> GetByOrganization(Guid OrganizationId, [Query] int offset, [Query] int count);
        [Get("/Event/Range/Organization/Member/{MemberId}")]
        public Task<ICollection<Models.Response.Event>> GetByMember(Guid MemberId, [Query] int offset, [Query] int count);
        [Post("/Event/")]
        public Task<Models.Response.Event> Add([Query] Guid OrganizationId);
        [Put("/Event/{EventId}/Inform")]
        public Task<Models.Response.EventInform> UpdateInform(Guid EventId, [Body] Models.Request.UpdateEventInform updateInform);
        [Put("/Event/{EventId}/Logo")]
        public Task<Models.Response.ImageInfo> UpdateLogo(Guid EventId, [Body] Models.Request.UpdateEventLogo updateLogo);
        [Post("/Event/{EventId}/Image")]
        public Task<ICollection<Models.Response.ImageInfo>> AddImage(Guid EventId, [Body] Models.Request.AddEventImage addEventImage);
        [Put("/Event/{EventId}/Image")]
        public Task<ICollection<Models.Response.ImageInfo>> UpdateImage(Guid EventId, [Body] Models.Request.UpdateEventImage updateEventImages);
        [Delete("/Event/{EventId}/Image/Many")]
        public Task DeleteImages(Guid EventId, [Body] Models.Request.DeleteEventImages deleteImages);
        [Put("/Event/{EventId}/Description")]
        public Task<ICollection<Models.Response.Description>> UpdateDescription(Guid EventId, [Body] Models.Request.UpdateEventDescription updateEventDescription);
        [Put("/Event/{EventId}/Price")]
        public Task<Models.Response.Price> UpdatePrice(Guid EventId, [Body] Models.Request.UpdateEventPrice updateEventPrice);
        [Put("/Event/{EventId}/Tags")]
        public Task<ICollection<Models.Response.Tag>> UpdateTags(Guid EventId, [Body] Models.Request.UpdateEventTags updateEventTags);
        [Put("/Event/{EventId}/WorkTime")]
        public Task<Models.Response.WorkTime> UpdateWorkTime(Guid EventId, [Body] Models.Request.UpdateEventWorkTime updateEventWorkTime);
        [Put("/Event/{EventId}/Address")]
        public Task<Models.Response.Address> UpdateAddress(Guid EventId, [Body] Models.Request.UpdateEventAddress updateEventAddress);
        [Put("/Event/{EventId}/MaxPlacesCount")]
        public Task<Models.Response.PlacesInfo> UpdateMaxPlacesCount(Guid EventId, [Query] int count);
        [Put("/Event/{EventId}/Status")]
        public Task<Models.Response.Event> UpdateStatus(Guid EventId, [Query] Models.Response.Enums.EventStatus status);
    }
}