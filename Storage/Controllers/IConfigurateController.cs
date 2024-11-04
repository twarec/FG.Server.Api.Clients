using FG.Server.Api.Clients.Storage.Models.Request.Configurate;
using FG.Server.Api.Clients.Storage.Models.Responce;
using Refit;

namespace FG.Server.Api.Clients.Storage.Controllers;

public interface IConfigurateController
{
    [Get("/Configurate/{name}")]
    public Task<string> GetAsync(string name);
    [Get("/Configurate/{name}/Content")]
    public Task<string> GetContentAsync(string name);
    [Get("/Configurate/Range")]
    public Task<IEnumerable<ConfigurateResponce>> GetRangeAsync([Query] int offset, [Query] int count);
    [Put("/Configurate")]
    public Task<ConfigurateResponce> CreateOrEditAsync([Body] PostConfigurateOptions options);

}
