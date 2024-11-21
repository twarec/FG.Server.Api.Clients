using FG.Server.Api.Clients.Main.Controllers;

namespace FG.Server.Api.Clients.Main;

public interface IMainClient
{
	public IEventController EventController { get; }
	public IKitchenController KitchenController { get; }
	public IUserController UserController { get; }
}
