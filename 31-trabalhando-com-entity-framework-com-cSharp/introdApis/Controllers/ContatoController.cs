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

        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome) {
            //esse Contatos é o dbSet, sua propriedade find
            var context = _context.Contatos.Where(x => x.Nome.Contains(nome));

            if (context == null)
                return NotFound();

            return Ok(context);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato) {
            var contatoBD = _context.Contatos.Find(id);

            if (contatoBD == null)
                return NotFound();

            contatoBD.Nome = contato.Nome;
            contatoBD.Telefone = contato.Telefone;
            contatoBD.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBD);
            _context.SaveChanges();

            return Ok(contatoBD);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id) {
            var contatoBD = _context.Contatos.Find(id);

            if (contatoBD == null)
                return NotFound();

            _context.Contatos.Remove(contatoBD);
            _context.SaveChanges();
            return NoContent(); //não há retorno, mas ouve sucesso.
        }

    }
}
