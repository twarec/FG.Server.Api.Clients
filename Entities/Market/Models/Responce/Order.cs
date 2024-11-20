using System;

namespace FG.Server.Api.Clients.Entities.Market.Models.Responce
{
    public class Order
    {
        public Guid Id { get; set; }
        public Responce.Enums.OrderStatus Status { get; set; }
        public int? PaymentId { get; set; } = new int?();
        public Responce.OrderInform OrderInfo { get; set; } = new Responce.OrderInform();
        public Details Details { get; set; } = new Details();
    }
}