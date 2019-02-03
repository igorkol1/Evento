using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Evento.Core.Domain;
using Evento.Core.Repositories;

namespace Evento.Infrastructure.Repositories
{
    public class EventRepository:IEventRepository
    {
        public EventRepository()
        {
        }

        public Task AddAsync(Event @event)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Event>> BrowseAsync(string name = "")
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Event @event)
        {
            throw new NotImplementedException();
        }

        public Task<Event> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Event> GetAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Event @event)
        {
            throw new NotImplementedException();
        }
    }
}
