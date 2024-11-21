using FG.Server.Api.Clients.Admin.Models.Request;
using FG.Server.Api.Clients.Admin.Models.Responce;
using Refit;

namespace FG.Server.Api.Clients.Admin.Controllers
{
    public interface IModerationUserController
    {
        [Get("/api/ModerationUser/{userId}/Position/Range")]
        public Task<List<ModerationUserPositionResponce>> GetPositionRangeAsync(long userId, [Query] int offset, [Query] int count);

        [Get("/api/ModerationUser/Range")]
        public Task<List<ModerationUserResponce>> GetRangeAsync([Query] int offset, [Query] int count);

        [Get("/api/ModerationUser/Range/Order/{isDesc}/Color")]
        public Task<List<ModerationUserResponce>> GetOrderedRangeAsync([Query] int offset, [Query] int count, bool isDesc);

        [Get("/api/ModerationUser/Range/Count")]
        public Task<int> GetCountAsync();

        [Get("/api/ModerationUser/Many")]
        public Task<List<ModerationUserResponce>> GetManytAsync([Query(CollectionFormat.Multi)] long[] users);

        [Put("/api/ModerationUser/{options.UserId}/Position")]
        public Task<string> UpdatePositionAsync(ModerationUserPositionOptions options);

        [Put("/api/ModerationUser/{id}/Banned")]
        public Task BanUserAsync(long id);

        [Post("/api/ModerationUser/{userId}/Change/Color")]
        public Task<ModerationUserResponce> ChangeColorAsync(long userId, [Query] string color);

        [Post("/api/ModerationUser/{userId}/Change/Description")]
        public Task<ModerationUserResponce> ChangeDescriptionAsync(long userId, [Query] string description);
    }
}
