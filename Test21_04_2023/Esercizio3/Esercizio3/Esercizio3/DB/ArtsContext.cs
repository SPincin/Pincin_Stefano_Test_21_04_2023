using Esercizio3.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3.DB
{
    public  class ArtsContext : DbContext
    {
        public ArtsContext() 
        {
        }

        public ArtsContext(DbContextOptions<ArtsContext> options):base(options)
        {

        }

        public virtual DbSet<Museum> Museums { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Artwork> Artworks { get; set; }
        public virtual DbSet<Character> Characters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
            .UseSqlServer(@"Data Source=STARSCREAM\SQLEXPRESS;Initial Catalog=Arts; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;");



    }
}
