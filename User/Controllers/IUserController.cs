using FG.Server.Api.Clients.User.Models.Request.Authorization;
using FG.Server.Api.Clients.User.Models.Request.User;
using FG.Server.Api.Clients.User.Models.Responce.User;
using Refit;
using System.Diagnostics.Contracts;

namespace FG.Server.Api.Clients.User.Controllers;

public partial interface IUserController
{
    [Get("/User")]
    public Task<UserResponce> GetUser(
		[Query] List<string> additionalModels);
    
    [Get("/User/Id/{userId}")]
    public Task<UserResponce> GetUserFromId(
        Guid userId,
		[Query] List<string> additionalModels);
    
    [Get("/User/Email/{email}")]
    public Task<UserResponce> GetUserFromEmail(
        string email,
		[Query] List<string> additionalModels);

    [Get("/User/Many/Id")]
    public Task<List<UserResponce>?> GetManyUsers(
        [Query(CollectionFormat = CollectionFormat.Multi)] List<Guid> usersId,
		[Query(CollectionFormat = CollectionFormat.Multi)] List<string> additionalModels);

	[Get("/User/Many/Email")]
	public Task<List<UserResponce>?> GetManyUsers(
		[Query(CollectionFormat = CollectionFormat.Multi)] List<string> emails,
		[Query(CollectionFormat = CollectionFormat.Multi)] List<string> additionalModels);

	[Put("/User")]
    public Task<UserResponce> EditUser(
        [Body] EditUserOptions options);

    [Put("/User/Password")]
    public Task EditPassword(
        [Body] EditUserPasswordOptions options);

    [Put("/User/Password/Recovery")]
    public Task RecoveryPassword(
        [Query] string email,
        [Query] string newPassword);

    [Put("/User/Password/Recovery/Verification")]
    public Task ConfirmationRecoveryPassword(
        [Query] string email,
        [Query] string code);

    [Delete("/User")]
    public Task Delete();
}