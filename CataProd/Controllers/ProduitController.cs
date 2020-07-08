using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CataProd.Models;
using Microsoft.AspNetCore.Mvc;

namespace CataProd.Controllers
{
    public class ProduitController : Controller
    {
        public ProduitContext dbContext { get; set; }

        public ProduitController(ProduitContext db)
        {
            this.dbContext = db;
        }
        // GET: /Produit/Index
        public IActionResult Index()
        {
            IEnumerable<Produit> produits = dbContext.Produits.ToList();
            return View("Produit", produits);
        }
    }
}