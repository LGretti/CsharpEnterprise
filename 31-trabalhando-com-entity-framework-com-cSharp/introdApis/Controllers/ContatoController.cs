using introdApis.Context;
using introdApis.Entities;
using Microsoft.AspNetCore.Mvc;

namespace introdApis.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase {

        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context) {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contato contato) {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id) {
            //esse Contatos é o dbSet, sua propriedade find
            var context = _context.Contatos.Find(id);

            if (context == null)
                return NotFound();

            return Ok(context);
        }

    }
}
