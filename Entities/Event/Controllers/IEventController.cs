using Refit;

namespace FG.Server.Api.Clients.Entities.Event.Controllers
{
    public interface IEventController
    {
        [Get("/Event/{EventId}")]
        public Task<Models.Responce.Event> Get(Guid EventId);
        [Get("/Event/Range/Organization/{OrganizationId}")]
        public Task<ICollection<Models.Responce.Event>> GetByOrganization(Guid OrganizationId, [Query] int offset, [Query] int count);
        [Get("/Event/Range/Organization/Member/{MemberId}")]
        public Task<ICollection<Models.Responce.Event>> GetByMember(Guid MemberId, [Query] int offset, [Query] int count);
        [Post("/Event/")]
        public Task<Models.Responce.Event> Add([Query] Guid OrganizationId);
        [Put("/Event/{EventId}/Inform")]
        public Task<Models.Responce.EventInform> UpdateInform(Guid EventId, [Body] Models.Request.UpdateEventInform updateInform);
        [Put("/Event/{EventId}/Logo")]
        public Task<Models.Responce.ImageInfo> UpdateLogo(Guid EventId, [Body] Models.Request.UpdateEventLogo updateLogo);
        [Post("/Event/{EventId}/Image")]
        public Task<ICollection<Models.Responce.ImageInfo>> AddImage(Guid EventId, [Body] Models.Request.AddEventImage addEventImage);
        [Put("/Event/{EventId}/Image")]
        public Task<ICollection<Models.Responce.ImageInfo>> UpdateImage(Guid EventId, [Body] Models.Request.UpdateEventIamge updateEventImages);
        [Delete("/Event/{EventId}/Image/Many")]
        public Task<ICollection<Models.Responce.Event>> DeleteImages(Guid EventId, [Body] Models.Request.DeleteEventImages deleteImages);
        [Put("/Event/{EventId}/Description")]
        public Task<ICollection<Models.Responce.Description>> UpdateDescription(Guid EventId, [Body] Models.Request.UpdateEventDesctiprion updateEventDescription);
        [Put("/Event/{EventId}/Price")]
        public Task<Models.Responce.Price> UpdatePrice(Guid EventId, [Body] Models.Request.UpdateEventPrice updateEventPrice);
        [Put("/Event/{EventId}/Tags")]
        public Task<ICollection<Models.Responce.Tag>> UpdateTags(Guid EventId, [Body] Models.Request.UpdateEventTags updateEventTags);
        [Put("/Event/{EventId}/WorkTime")]
        public Task<Models.Responce.WorkTime> UpdateWorkTime(Guid EventId, [Body] Models.Request.UpdateEventWorkTime updateEventWorkTime);
        [Put("/Event/{EventId}/Address")]
        public Task<Models.Responce.Address> UpdateAddress(Guid EventId, [Body] Models.Request.UpdateEventAddress updateEventAddress);
        [Put("/Event/{EventId}/MaxPlacesCount")]
        public Task<Models.Responce.Event> UpdateMaxPlacesCount(Guid EventId, [Query] int count);
        [Put("/Event/{EventId}/Status")]
        public Task<Models.Responce.Event> UpdateStatus(Guid EventId, [Query] Models.Responce.Enums.EventStatus status);
    }
}