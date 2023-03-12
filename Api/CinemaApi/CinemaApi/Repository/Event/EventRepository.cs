using CinemaApi.Entities.Context;
using CinemaApi.Entities.Entities;

namespace CinemaApi.Repository.Event
{
    using Event = CinemaApi.Entities.Entities.Event;

    public class EventRepository : IEventRepository
    {
        private readonly CinemaApiContext _context;

        public EventRepository()
        {
            _context = new CinemaApiContext();
        }

        public IEnumerable<Event> GetAllEvents()
        {
            return _context.Events.ToList();
        }

        public Event? GetEventById(int id)
        {
            return _context.Events.FirstOrDefault(e => e.Id == id);
        }
    }
}
