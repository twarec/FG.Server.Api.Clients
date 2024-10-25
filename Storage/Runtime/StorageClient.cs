using FG.Server.Api.Clients.Storage.Controllers;

namespace FG.Server.Api.Clients.Storage.Runtime;

public class StorageClient(HttpClient client) : IStorageClient
{
    public Uri? Url => client.BaseAddress;

    public IFileController FileController { get; private set; } = Refit.RestService.For<IFileController>(client);
    public IGroupController GroupController { get; private set; } = Refit.RestService.For<IGroupController>(client);
    public IStackController StackController { get; private set; } = Refit.RestService.For<IStackController>(client);

}