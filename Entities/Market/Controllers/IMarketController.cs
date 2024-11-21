using Refit;

namespace FG.Server.Api.Clients.Entities.Market.Controllers
{
    public interface IMarketController
    {
        [Get("/Market/{MarketId}")]
        public Task<Models.Responce.Market> Get(Guid MarketId);
        [Get("/Market/Range/Organization/{OrganizationId}")]
        public Task<ICollection<Models.Responce.Market>> GetByOrganization(Guid OrganizationId, [Query] int offset, [Query] int count);
        [Get("/Market/Range/Organization/Member/{MemberId}")]
        public Task<ICollection<Models.Responce.Market>> GetByMember(Guid MemberId, [Query] int offset, [Query] int count);
        [Post("/Market/")]
        public Task<Models.Responce.Market> Add([Query] Guid OrganizationId);
        [Put("/Market/{MarketId}/Inform")]
        public Task<Models.Responce.MarketInfo> UpdateInform(Guid MarketId, [Body] Models.Request.UpdateMarketInform updateInform);
        [Put("/Market/{MarketId}/Logo")]
        public Task<Models.Responce.ImageInfo> UpdateLogo(Guid MarketId, [Body] Models.Request.UpdateMarketLogo updateLogo);
        [Put("/Market/{MarketId}/Address")]
        public Task<Models.Responce.Address> UpdateAddress(Guid MarketId, [Body] Models.Request.UpdateMarketAddress updateAddress);
        [Put("/Market/{MarketId}/Tags")]
        public Task<ICollection<Models.Responce.Tag>> UpdateTags(Guid MarketId, [Body] Models.Request.UpdateMarketTags updateTags);
        [Put("/Market/{MarketId}/DeliverySettings")]
        public Task<Models.Responce.DeliverySettings> UpdateDeliverySettings(Guid MarketId, [Body] Models.Request.UpdateMarketDeliverySettings updateDeliverySettings);
        [Put("/Market/{MarketId}/ServiceSettings")]
        public Task<Models.Responce.ServiceSettings> UpdateServiceSettings(Guid MarketId, [Body] Models.Request.UpdateMarketServiceSettings updateServiceSettings);
        [Put("/Market/{MarketId}/Status")]
        public Task UpdateStatus(Guid MarketId, [Query] Models.Responce.Enums.MarketStatus status);
    }
}