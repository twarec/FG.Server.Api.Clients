using System;

namespace FG.Server.Api.Clients.User.Models.Responce;

public class AuthorizateResponce
{
    public UserResponce User { get; set; } = new();
    public Guid SessionId { get; set; }
}
