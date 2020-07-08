using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CataProd.Models
{
    [Table("CATEGORIES")]
    public class Categorie
    {
        [Key]
        public int CategorieID { get; set; }
        [StringLength(30)]
        public string NomCategorie { get; set; }
        public ICollection<Produit> Produits { get; set; }
    }
}
