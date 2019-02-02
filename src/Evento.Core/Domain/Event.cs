using System;
using System.Collections.Generic;

namespace Evento.Core.Domain
{
    public class Event : Entity
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime StartDate { get; protected set; }
        public DateTime EndDate { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }
        public IEnumerable<Ticket> Tickets => _tickets;

        private ISet<Ticket> _tickets = new HashSet<Ticket>();

        protected Event() { }

        public Event(Guid id,string name,string description,DateTime startDate,DateTime endDate)
        {
            base.Id = id;
            this.Name = name;
            this.Description = description;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.CreatedAt = DateTime.UtcNow;
            this.UpdatedAt = DateTime.UtcNow;
        }

        public void AddTickets(int amount,decimal price)
        {
            var seating = _tickets.Count + 1;
            for(int i = 0; i < amount; i++)
            {
                _tickets.Add(new Ticket(this, seating,price));
                seating++;
            }
        }

    }
}
