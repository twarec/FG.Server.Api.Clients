using FG.Server.Api.Clients.Admin.Models.Request;
using FG.Server.Api.Clients.Admin.Models.Responce;
using Refit;

namespace FG.Server.Api.Clients.Admin.Controllers
{
    public interface IModerationController
    {
        [Get("/api/Moderation/Range/Many")]
        public Task<List<ModerationResponce>> GetManyAsync(int[] ids);

        [Get("/api/Moderation/Range/Many/Count")]
        public Task<int> GetManyCountAsync(int[] ids);

        [Get("/api/Moderation/Range/Many")]
        public Task<List<ModerationResultResponce>> GetResponceManyAsync(int[] ids);

        [Get("/api/Moderation/Responce/Range/Many/Count")]
        public Task<int> GetResponceManyCountAsync(int[] ids);

        [Get("/api/Moderation/{grouped}/Range")]
        public Task<List<ModerationResponce>> GetRangeAsync([Query] int offset, [Query] int count, string grouped);

        [Get("/api/Moderation/{grouped}/Range/Count")]
        public Task<int> GetCountAsync(string grouped);

        [Get("/api/Moderation/{grouped}/Next")]
        public Task<ModerationResponce> GetNextAsync(string grouped);

        [Get("/api/Moderation/Range/All/{dateTime}/After")]
        public Task<List<ModerationResponce>> GetAfterAsync(DateTime dateTime);

        [Get("/api/Moderation/Responce/Range/All/{dateTime}/After")]
        public Task<List<ModerationResponce>> GetResponceAfterAsync(DateTime dateTime);

        [Post("/api/Moderation/Responce")]
        public Task<ModerationResponce> AddResponceAsync([Body] ModerationResponceOptions options);

        [Post("/api/Moderation/{id}/Blocked/Time")]
        public Task<ModerationResponce> BlockForTimeAsync(int id, [Query] long seconds);
    }
}
