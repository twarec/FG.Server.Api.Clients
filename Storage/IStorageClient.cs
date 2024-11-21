using FG.Server.Api.Clients.Storage.Controllers;

namespace FG.Server.Api.Clients.Storage;

public interface IStorageClient
{
	public Uri? Url { get; }

	public IFileController FileController { get; }
	public IGroupController GroupController { get; }
	public IStackController StackController { get; }
	public IConfigurateController ConfigurateController { get; }

}
