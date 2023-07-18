﻿using Microsoft.AspNetCore.Mvc;
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
      return NotFound();

    return View(contato);
  }
}