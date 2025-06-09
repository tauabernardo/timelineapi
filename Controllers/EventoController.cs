    using Microsoft.AspNetCore.Mvc;
    using TimeLineApi.Data;
    using TimeLineApi.DTOs;
    using TimeLineApi.Models;

    namespace TimeLineApi.Controllers
    {
        [ApiController]
        [Route("api/[controller]")]
        public class EventoController : ControllerBase
        {
            private readonly AppDbContext _context;

            public EventoController(AppDbContext context)
            {
                _context = context;
            }

            [HttpGet]
            public IActionResult Get()
            {
                var eventos = _context.Eventos.ToList();
                return Ok(eventos);
            }

            [HttpPost]
            public IActionResult Create(EventoDTO dto)
            {
                var evento = new Evento
                {
                    Titulo = dto.Titulo,
                    Descricao = dto.Descricao,
                    Data = dto.Data
                };

                _context.Eventos.Add(evento);
                _context.SaveChanges();

                return CreatedAtAction(nameof(GetById), new { id = evento.Id }, evento);
            }

            [HttpGet("{id}")]
            public IActionResult GetById(int id)
            {
                var evento = _context.Eventos.Find(id);
                if (evento == null) return NotFound();

                return Ok(evento);
            }

            [HttpPut("{id}")]
            public IActionResult Update(int id, EventoDTO dto)
            {
                var evento = _context.Eventos.Find(id);
                if (evento == null) return NotFound();

                evento.Titulo = dto.Titulo;
                evento.Descricao = dto.Descricao;
                evento.Data = dto.Data;

                _context.SaveChanges();
                return NoContent();
            }

            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                var evento = _context.Eventos.Find(id);
                if (evento == null) return NotFound();

                _context.Eventos.Remove(evento);
                _context.SaveChanges();
                return NoContent();
            }
        }
    }
