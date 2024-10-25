using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GerenciadorDeTarefasAPI.Models;

namespace GerenciadorDeTarefasAPI.Context
{
    public class OrganizadorContext : DbContext
    {
         public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {

        }
        
        //representa uma tabela atraves do comando DbSet
                public DbSet<Tarefa> Tarefas{ get; set; }
    }
}