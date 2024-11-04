using FG.Server.Api.Clients.User.Models.Request;
using FG.Server.Api.Clients.User.Models.Responce;
using Refit;

namespace FG.Server.Api.Clients.User.Controllers;

public interface IUserController
{
    [Get("/User")]
    public Task<UserResponce> Get(
        [Query] Guid userId);

    [Get("/User/Many")]
    public Task<List<UserResponce>?> GetMany(
        [Query(CollectionFormat = CollectionFormat.Multi)] List<Guid> usersId);

    [Put("/User")]
    public Task<UserResponce> Edit(
        [Query] Guid userId, 
        [Body] EditUserOptions options);

    [Get("/User/Connect/AuthMethod/Email")]
    public Task<AddEmailAuthorizationResponce> AddEmail(
        [Query] Guid userId, 
        [Body] AuthorizationEmailOptions options);

    //[Get("/Connect/AuthMethod/Google")]
    //public Task<AddGoogleAuthorizationResponce> AddGoogle(
    //    [Query] Guid userId);

    //[Get("/Connect/AuthMethod/Apple")]
    //public Task<AddAppleAuthorizationResponce> AddApple(
    //    [Query] Guid userId);
}