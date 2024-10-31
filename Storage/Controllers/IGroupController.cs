using FG.Server.Api.Clients.Storage.Models.Responce;
using Refit;

namespace FG.Server.Api.Clients.Storage.Controllers;

public interface IGroupController
{
    [Get("/Group/Range/{offset}/{count}")]
    public Task<IEnumerable<FileGroupResponce>> GeRangeAsync(int offset, int count);

    [Post("/Group")]
    public Task<FileGroupResponce> AddAsync([Query] string name);

    [Delete("/Group/{id}")]
    public Task<bool> DeleteAsync(Guid id);
}
