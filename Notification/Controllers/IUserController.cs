using FG.Server.Notification.Api.Models.Request;
using FG.Server.Notification.Api.Models.Responce;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FG.Server.Api.Clients.Notification.Controllers
{
	public interface IUserController
	{
		public partial interface IUserController
		{
			[Post("/Notification/User/Connect/{userId}")]
			public Task<UserResponce> ConnectUser(
				Guid userId,
				[Body] DeviceOptions options);

			[Delete("/Notification/User/{userId}")]
			public Task DeleteUser(
				Guid userId);
		}
	}
}
