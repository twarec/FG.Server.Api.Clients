using System;

namespace FG.Server.Api.Clients.Entities.Models.Response
{
    public class PlacesInfo
    {
        public Guid Id { get; set; }
        public int MaxNumberOfPlaces { get; set; }
        public int NumberFreeOfPlaces { get; set; }
    }
}