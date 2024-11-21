using FG.Server.Api.Clients.Storage.Models.Request;
using FG.Server.Api.Clients.Storage.Models.Responce;
using Refit;

namespace FG.Server.Api.Clients.Storage.Controllers;

public interface IFileController
{
	[Get("/File/{id}")]
	public Task<FileResponce> GetAsync(Guid id);
	[Get("/File/{id}/Content")]
	public Task<HttpContent> GetContentAsync(Guid id);
	[Get("/File/{id}/Expanded")]
	public Task<FileResponce> GetExpandedAsync(Guid id);
	[Get("/File/Range/{offset}/{count}/Tag")]
	public Task<IEnumerable<FileResponce>> GetRangeAsync(int offset, int count, [Query] string group, [Query] string key, [Query] string value);
	[Get("/File/Range/{offset}/{count}")]
	public Task<IEnumerable<FileResponce>> GetRangeAsync(int offset, int count, [Query] string group);
	[Get("/File/Range/{offset}/{count}/Tag/Expanded")]
	public Task<IEnumerable<FileResponce>> GetRangeExpandedAsync(int offset, int count, [Query] string group, [Query] string key, [Query] string value);
	[Get("/File/Range/{offset}/{count}/Expanded")]
	public Task<IEnumerable<FileResponce>> GetRangeExpandedAsync(int offset, int count, [Query] string group);
	[Post("/File")]
	public Task<FileResponce> AddAsync([Body] PostFileOptions oprions);
	[Post("/File/Image")]
	public Task<FileResponce> AddImageAsync([Body] PostImageOptions oprions);
	[Post("/File/{id}/Metadata")]
	public Task<bool> AddMetadataAsync([Query] string key, [Query] string value, Guid id);
	[Put("/File/Content")]
	public Task<bool> UpdateAsync([Body] PutContentOptions options);
	[Put("/File/Image/Content")]
	public Task<bool> UpdateImageAsync([Body] PutImageOptions options);
	[Delete("/File/{id}")]
	public Task<bool> DeleteAsync(Guid id);
}
