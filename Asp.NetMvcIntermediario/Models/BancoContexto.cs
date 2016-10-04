using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Asp.NetMvcIntermediario.Models
{
    public class BancoContexto : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Professor> Professores { get; set; }

        public DbSet<Topico> Topicos { get; set; }
    }
}