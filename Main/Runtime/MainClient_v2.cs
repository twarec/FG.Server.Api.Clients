using FG.Server.Api.Clients.Main.Controllers;

namespace FG.Server.Api.Clients.Main.Runtime;

public class MainClient_v2(HttpClient client) : IMainClient
{
    public IEventController EventController => Refit.RestService.For<IEventController>(client);
}
