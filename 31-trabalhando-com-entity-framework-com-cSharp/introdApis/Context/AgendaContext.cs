﻿using Microsoft.EntityFrameworkCore;
using introdApis.Entities;

namespace introdApis.Context {
    public class AgendaContext : DbContext {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) { }

        public DbSet<Contato> Contatos { get; set; }

    }
}