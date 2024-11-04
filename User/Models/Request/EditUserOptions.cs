using System;

namespace FG.Server.Api.Clients.User.Models.Request;

public class EditUserOptions
{
    public string FirstName { get; set; } = string.Empty;
    public string MiddleName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime? Brith { get; set; } = null;
    public string Login { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;

}
