using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Evento.Core.Repositories;
using Evento.Infrastructure.DTO;

namespace Evento.Infrastructure.Services
{
    public class EventService:IEventService
    {
        private readonly IEventRepository eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            this.eventRepository = eventRepository;
        }

        public async Task<EventDto> GetAsync(Guid id)
        {
            var @event = await eventRepository.GetAsync(id);
            return new EventDto
            {
                Id = @event.Id,
                Name = @event.Name,
            };

        }

        public async Task<EventDto> GetAsync(string name)
        {
            var @event = await eventRepository.GetAsync(name);
            return new EventDto
            {
                Id = @event.Id,
                Name = @event.Name,
            };

        }

        public async Task<IEnumerable<EventDto>> BrowseAsync(string name = null)
        {
            var events = await eventRepository.BrowseAsync(name);
            return events.Select(@event => new EventDto
            {
                Id = @event.Id,
                Name = @event.Name,
            });
        }

        public async Task CreateAsync(Guid id, string name, string description, DateTime startDate, DateTime finishDate)
        {
            throw new NotImplementedException();
        }

        public async Task AddTicketAsync(Guid id, int amount, decimal price)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Guid id, string name, string description)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
