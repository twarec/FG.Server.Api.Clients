using System;

namespace FG.Server.Organization.Api.Client.Models.Request
{
    public class UpdateMemberTags
    {
        public List<String> Tags { get; set; } = new List<String>();
    }
}