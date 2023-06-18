using Microsoft.AspNetCore.Mvc;

namespace ProjetoMVC;
public class ContatoController : Controller
{
  //Listar todos os contatos no banco
  public IActionResult Index(){
    return View();
  }
}
