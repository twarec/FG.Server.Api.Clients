using FG.Server.Api.Clients.User.Models.Request;
using FG.Server.Api.Clients.User.Models.Responce.User;
using Refit;
using System.Diagnostics.Contracts;

namespace FG.Server.Api.Clients.User.Controllers;

public interface IUserController
{
    [Get("/User")]
    public Task<UserResponce> GetUser(
        [Query] Guid userId);

    [Get("/User/Many")]
    public Task<List<UserResponce>?> GetManyUsers(
        [Query(CollectionFormat = CollectionFormat.Multi)] List<Guid> usersId);

    [Put("/User")]
    public Task<UserResponce> EditUser(
        [Query] Guid userId, 
        [Body] EditUserOptions options);

    [Get("/User/Connect/AuthMethod/Email")]
    public Task<AddEmailAuthorizationResponce> AddEmail(
        [Query] Guid userId, 
        [Body] AuthorizationEmailOptions options);

    [Put("/User/Password/Recovery")]
    public Task RecoveryPassword(
        [Query] string email,
        [Query] string newPassword);

    [Put("/User/Password/Recovery/Verification")]
    public Task ConfirmationRecoveryPassword(
        [Query] string email,
        [Query] string code);

    [Get("/User/Properties")]
    public Task<UserPropertyResponce> GetProperties(
        UserPropertyOptions options);

    [Get("/User/Properties/Stacks")]
    public Task<UserStackPropertyResponce> GetAllUserStacksProperties(
        [Query] Guid userId);

    [Post("/User/Properties")]
    public Task<UserStackPropertyResponce> SetProperties(
        [Body] SetUserPropertyOptions options);

    [Get("/User/Properties/Stacks/Names")]
    public Task<List<string>> GetUserNamesStacks(
        [Query] Guid userId);

    [Get("/User/Properties/Stacks/Stack")]
    public Task<UserStackPropertyResponce> GetUserStackProperties(
        [Query] Guid userId,
        [Query] string stackName);

    [Delete("/User/Properties")]
    public Task<UserStackPropertyResponce> RemoveProperties(
        [Body] UserPropertyOptions options);
    
    [Delete("/User/Properties/Stack")]
    public Task RemoveStackProperties(
        [Query] Guid userId,
        [Query] string stackName);

	//[Get("/Connect/AuthMethod/Google")]
	//public Task<AddGoogleAuthorizationResponce> AddGoogle(
	//    [Query] Guid userId);

	//[Get("/Connect/AuthMethod/Apple")]
	//public Task<AddAppleAuthorizationResponce> AddApple(
	//    [Query] Guid userId);
}