using CataProd.Models;
using System;

namespace TestCata
{
    class Program
    {
        public static void Main(string[] args)
        {
            using(var db=new ProduitContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
               db.Categories.Add(
                    new Categorie { NomCategorie = "Ordinateurs" }
                    );
                db.Categories.Add(
                    new Categorie { NomCategorie = "Smartphones" }
                    );
                db.Categories.Add(
                    new Categorie { NomCategorie = "Imprimantes" }
                    );
                db.Produits.Add(
                    new Produit
                    {
                        Designation = "HP 65 90",
                        Prix = 7800,
                        Quantite = 6,
                        CategorieID = 1
                    }
                    );
                db.Produits.Add(
                    new Produit
                    {
                        Designation = "Samsumg",
                        Prix = 5000,
                        Quantite = 12,
                        CategorieID = 2
                    }
                    );
                db.Produits.Add(
                    new Produit
                    {
                        Designation = "Node Book Pro",
                        Prix = 7600,
                        Quantite = 11,
                        CategorieID = 1
                    }
                    );
                db.Produits.Add(
                    new Produit
                    {
                        Designation = "EPSON 5498",
                        Prix = 12000,
                        Quantite = 6,
                        CategorieID = 3
                    }
                    );
                db.Produits.Add(
                   new Produit
                   {
                       Designation = "Nokia",
                       Prix = 7800,
                       Quantite = 6,
                       CategorieID = 1
                   }
                   );
                db.Produits.Add(
                    new Produit
                    {
                        Designation = "Alcatel",
                        Prix = 5000,
                        Quantite = 12,
                        CategorieID = 2
                    }
                    );
                db.Produits.Add(
                    new Produit
                    {
                        Designation = "Sharp",
                        Prix = 7600,
                        Quantite = 11,
                        CategorieID = 1
                    }
                    );
                db.Produits.Add(
                    new Produit
                    {
                        Designation = "EPSON 5498",
                        Prix = 12000,
                        Quantite = 6,
                        CategorieID = 3
                    }
                    );
                db.Produits.Add(
                   new Produit
                   {
                       Designation = "HP 65 90",
                       Prix = 7800,
                       Quantite = 6,
                       CategorieID = 1
                   }
                   );
                db.Produits.Add(
                    new Produit
                    {
                        Designation = "Samsumg",
                        Prix = 5000,
                        Quantite = 12,
                        CategorieID = 2
                    }
                    );
                db.Produits.Add(
                    new Produit
                    {
                        Designation = "Node Book Pro",
                        Prix = 7600,
                        Quantite = 11,
                        CategorieID = 1
                    }
                    );
                db.Produits.Add(
                    new Produit
                    {
                        Designation = "EPSON 5498",
                        Prix = 12000,
                        Quantite = 6,
                        CategorieID = 3
                    }
                    );
                db.SaveChanges();
            }
        }
    }
}
