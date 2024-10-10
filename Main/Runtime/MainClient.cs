using FG.Server.Api.Clients.Main.Controllers;

namespace FG.Server.Api.Clients.Main.Runtime;

public class MainClient(HttpClient client) : IMainClient
{
    public IEventController EventController { get; } = Refit.RestService.For<IEventController>(client);
    public IKitchenController KitchenController { get; } = Refit.RestService.For<IKitchenController>(client);
    public IUserController UserController { get; } = Refit.RestService.For<IUserController>(client);
}
