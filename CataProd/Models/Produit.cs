﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CataProd.Models
{
    [Table("PRODUITS")]
    public class Produit
    {
        [Key]
        public int ProduitID { get; set; }
        [StringLength(70)]
        [Required]
        [MinLength(4), MaxLength(70)]
        public string Designation { get; set; }
        [Range(10, 50000)]
        public double Prix { get; set; }
        public int Quantite { get; set; }
        public int CategorieID { get; set; }
        public virtual Categorie Categorie { get; set; }
    }
}
