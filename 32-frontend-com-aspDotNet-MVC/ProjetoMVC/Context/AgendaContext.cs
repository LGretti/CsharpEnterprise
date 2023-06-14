using Microsoft.EntityFrameworkCore;

namespace ProjetoMVC;
public class AgendaContext : DbContext {
  public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) { }

  

}
