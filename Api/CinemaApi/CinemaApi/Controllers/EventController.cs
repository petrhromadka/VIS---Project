using CinemaApi.Repository.Event;
using Microsoft.AspNetCore.Mvc;
using Event = CinemaApi.Entities.Entities.Event;

namespace CinemaApi.Controllers
{
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventRepository _eventRepository;

        public EventController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        [HttpGet("api/events")]
        public IEnumerable<Event> GetAllEvents()
        {
            return _eventRepository.GetAllEvents();
        }

        [HttpGet("api/events/{id}")]
        public Event? GetEventById(int id)
        {
            return _eventRepository.GetEventById(id);
        }
    }
}
