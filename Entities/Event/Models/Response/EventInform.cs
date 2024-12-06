using System;

namespace FG.Server.Api.Clients.Entities.Event.Models.Response
{
    public class EventInform
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public Response.ImageInfo Logo { get; set; } = new Response.ImageInfo();
        public Response.Price Price { get; set; } = new Response.Price();
        public Response.WorkTime WorkTime { get; set; } = new Response.WorkTime();
        public Address Address { get; set; } = new Address();
        public Response.PlacesInfo PlacesInfo { get; set; } = new Response.PlacesInfo();
        public ICollection<Response.Tag> Tags { get; set; } = [];
        public ICollection<Response.ImageInfo> ImagesInfo { get; set; } = [];
        public ICollection<Description> Descriptions { get; set; } = [];
    }
}