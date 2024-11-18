using FG.Server.Api.Clients.User.Models.Request.Authorization;
using FG.Server.Api.Clients.User.Models.Request.User;
using FG.Server.Api.Clients.User.Models.Responce.User;
using Refit;
using System.Diagnostics.Contracts;

namespace FG.Server.Api.Clients.User.Controllers;

public interface IUserController
{
    [Get("/User")]
    public Task<UserResponce> GetUser(
		[Query] List<string> additionalModels);
    
    [Get("/User/Id/{userId}")]
    public Task<UserResponce> GetUserFromId(
        [Query] Guid userId,
		[Query] List<string> additionalModels);
    
    [Get("/User/Email/{email}")]
    public Task<UserResponce> GetUserFromEmail(
        [Query] string email,
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


    [Get("/User/Connect/AuthMethod/Email")]
    public Task<AddEmailAuthorizationResponce> AddEmail(
        [Query] Guid userId, 
        [Body] AuthorizationEmailOptions options);

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

    [Get("/User/Properties")]
    public Task<UserPropertyResponce> GetProperties(
        [Body]UserPropertyOptions options);

    [Get("/User/Properties/{userId}")]
    public Task<UserPropertyResponce> GetPropeties(
        Guid userId,
        [Body]UserPropertyOptions options);

    [Get("/User/Properties/Stacks")]
    public Task<UserStackPropertyResponce> GetAllUserStacksProperties();
    
    [Get("/User/Properties/Stacks{userId}")]
    public Task<UserStackPropertyResponce> GetAllUserStacksProperties(
        Guid userId);

    [Post("/User/Properties")]
    public Task<UserStackPropertyResponce> SetProperties(
        [Body] SetUserPropertyOptions options);

    [Get("/User/Properties/Stacks/Names")]
    public Task<List<string>> GetUserNamesStacks();
    
    [Get("/User/Properties/Stacks/Names/{userId}")]
    public Task<List<string>> GetUserNamesStacks(
        Guid userId);

    [Get("/User/Properties/Stacks/Stack")]
    public Task<UserStackPropertyResponce> GetUserStackProperties(
        [Query] string stackName);
    
    [Get("/User/Properties/Stacks/Stack/{userId}")]
    public Task<UserStackPropertyResponce> GetUserStackProperties(
        Guid userId,
        [Query] string stackName);

    [Delete("/User/Properties")]
    public Task<UserStackPropertyResponce> RemoveProperties(
        [Body] UserPropertyOptions options);
    
    [Delete("/User/Properties/Stack")]
    public Task RemoveStackProperties(
        [Query] string stackName);

    [Get("/User/Images/Avatar")]
    public Task GetAvatar(
        [Query] string sizeFormat);
    
    [Get("/User/Images/Avatar/{userId}")]
    public Task GetAvatar(
        Guid avatarId,
        [Query] string sizeFormat);

    [Post("/User/Images/Avatar")]
    public Task<Guid> SetAvatar(
        [Body] SetAvatarOptions options);

    [Multipart]
    [Post("/User/Images/Avatar/Form")]
    public Task<Guid> SetAvatarFromForm(
        [AliasAs("avatar")] StreamPart stream);

    [Delete("/User/Images/Avatar")]
    public Task<bool> DeleteAvatar();

    [Delete("/User")]
    public Task Delete();
}