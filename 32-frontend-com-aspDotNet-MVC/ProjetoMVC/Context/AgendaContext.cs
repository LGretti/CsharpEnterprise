using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Models;

namespace ProjetoMVC;
public class AgendaContext : DbContext {
    // Construtor que passa a opção genérica para a classe base DbContext
    public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) { }

    //propriedade DBset(tabela) - como se a Agenda fosse a base e o dbset a tabela
    public DbSet<Contato> Contatos { get; set; }

}
