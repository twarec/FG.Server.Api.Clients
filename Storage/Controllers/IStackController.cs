using FG.Server.Api.Clients.Storage.Models.Request;
using FG.Server.Api.Clients.Storage.Models.Responce;
using Refit;

namespace FG.Server.Api.Clients.Storage.Controllers;

public interface IStackController
{
    [Post("/Stack/Image")]
    public Task<FileStackResponce> GenerateImages([Body] PostImageStackOptions options);
    [Delete("/Stack/{id}")]
    public Task<bool> DeleteStackAsync(Guid id, [Query] bool isDeletaFiles = false);
    [Post("/Stack")]
    public Task<FileStackResponce> AddStackAsync([Body] PostFileStackOptions oprions);
    [Get("/Stack/{id}")]
    public Task<FileStackResponce> GetStackAsync(Guid id);
    [Get("/Stack/{id}/{key}/Expanded")]
    public Task<FileResponce> GetFromStackExpandedAsync(Guid id, string key);
    [Get("/Stack/{id}/{key}/Content")]
    public Task<HttpContent> GetContentFromStackAsync(Guid id, string key);
    [Get("/Stack/{id}/{key}")]
    public Task<FileResponce> GetFromStackAsync(Guid id, string key);
}
