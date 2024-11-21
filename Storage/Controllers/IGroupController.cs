using FG.Server.Api.Clients.Storage.Models.Responce;
using Refit;

namespace FG.Server.Api.Clients.Storage.Controllers;

public interface IGroupController
{
    [Get("/Group/{group}/Range/{offset}/{count}")]
    public Task<IEnumerable<FileResponce>> GeRangeAsync(string group, int offset, int count);

    [Delete("/Group/{group}")]
    public Task<bool> DeleteAsync(string group);
}
