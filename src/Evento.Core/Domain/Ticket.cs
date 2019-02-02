﻿using System;
namespace Evento.Core.Domain
{
    public class Ticket: Entity
    {
        public Guid EventId { get; protected set; }
        public int Seating { get; protected set; }
        public decimal Price { get; protected set; }
        public Guid UserId { get; protected set; }
        public string Username { get; protected set; }
        public DateTime PurchesedAt { get; protected set; }
        public bool Purchased => UserId != null;

        protected Ticket(){}

        public Ticket(Event @event, int seating,decimal price)
        {
            this.EventId = @event.Id;
            this.Seating = seating;
            this.Price = price;
        }
    }
}
