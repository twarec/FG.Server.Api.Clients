using System;
using FG.Server.Api.Clients.User.Models.Request;
using FG.Server.Api.Clients.User.Models.Responce;
using Refit;

namespace FG.Server.Api.Clients.User.Controllers;

public interface IAuthorizateController
{
    [Get("User/Authorizate/Email")]
    public Task<AuthorizateEmailResponce> AutorizateFromEmail([Body] AuthorizationEmailOptions options);

    [Get("User/Authorizate/Email/Verification")]
    public Task SendVerification([Query] string email);

    [Put("User/Authorizate/Email/Verification")]
    public Task Verification([Query] string email, [Query] string code);

    [Get("User/Authorizate/Google")]
    public Task<AuthorizateGoogleResponce> AuthorizateFromGoogle(AuthorizationOptions options);

    [Get("User/Authorizate/Apple")]
    public Task<AuthorizateAppleResponce> AuthorizateFromApple(AuthorizationOptions options);
}
