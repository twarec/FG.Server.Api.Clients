using FG.Server.Api.Clients.User.Models.Request.Authorization;
using FG.Server.Api.Clients.User.Models.Responce.Authorization;
using Refit;

namespace FG.Server.Api.Clients.User.Controllers;

public interface IAuthorizateController
{
	[Get("/User/Authorizate/Session")]
	public Task<AuthorizateResponce> AuthorizateFromSession(
		[Query] Guid userId,
		[Query] Guid sessionId);

	[Get("/User/Authorizate/Email")]
	public Task<AuthorizateEmailResponce> AutorizateFromEmail(
		[Query] AuthorizationEmailOptions options);

	[Get("/User/Authorizate/Email/Verification")]
	public Task SendVerification(
		[Query] string email);

	[Put("/User/Authorizate/Email/Verification")]
	public Task<AuthorizateEmailResponce> Verification(
		[Query] string email,
		[Query] string code);

	//[Get("/User/Authorizate/Google")]
	//public Task<AuthorizateGoogleResponce> AuthorizateFromGoogle(
	//    AuthorizationOptions options);

	//[Get("/User/Authorizate/Apple")]
	//public Task<AuthorizateAppleResponce> AuthorizateFromApple(
	//    AuthorizationOptions options);
}
