using System;

namespace FG.Server.Api.Clients.Entities.Models.Request
{
    public class UpdateMemberTags
    {
        public List<string> Tags { get; set; } = new List<string>();
    }
}