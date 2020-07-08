using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CataProd.Models
{
    public class ProduitContext : DbContext
    {
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Categorie> Categories { get; set; }

        public ProduitContext() : base()
        {

        }
        public ProduitContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb; Initial Catalog=CatawDb ;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
