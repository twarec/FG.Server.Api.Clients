using FG.Server.Api.Clients.Admin.Controllers;

namespace FG.Server.Api.Clients.Admin
{
	public interface IAdminClient
	{
		public IAuthController AuthController { get; }


	}
}
