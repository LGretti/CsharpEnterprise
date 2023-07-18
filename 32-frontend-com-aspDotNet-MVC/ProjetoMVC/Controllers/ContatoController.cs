using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Models;

namespace ProjetoMVC;
public class ContatoController : Controller
{
  private readonly AgendaContext _context;

  public ContatoController(AgendaContext context){
    _context = context;
  }
  public IActionResult Index(){
    var contatos = _context.Contatos.ToList();
    return View(contatos);
  }

  public IActionResult Criar() {
    return View();
  }

  [HttpPost]
  public IActionResult Criar(Contato contato){
    if (ModelState.IsValid){
      _context.Contatos.Add(contato);
      _context.SaveChanges();
      return RedirectToAction(nameof(Index));
    }
    return View(contato);
  }

  public IActionResult Editar(int id) {
    var contato = _context.Contatos.Find(id);
    
    if (contato == null)
      return RedirectToAction(nameof(Index));

    return View(contato);
  }

  [HttpPost]
  public IActionResult Editar(Contato contato){
    Contato contatoBD =  _context.Contatos.Find(contato.Id);

    contatoBD.Nome     = contato.Nome;
    contatoBD.Telefone = contato.Telefone;
    contatoBD.Ativo    = contato.Ativo;

    _context.Contatos.Update(contatoBD);
    _context.SaveChanges();

    return RedirectToAction(nameof(Index));
  }

  public IActionResult Detalhes(int id) {
    var contato = _context.Contatos.Find(id);
    
    if (contato == null)
      return RedirectToAction(nameof(Index));

    return View(contato);
  }
}
