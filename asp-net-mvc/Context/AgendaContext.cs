using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp_net_mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace asp_net_mvc.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
        }
        public DbSet<Contato> Contatos { get; set; }
    }
}