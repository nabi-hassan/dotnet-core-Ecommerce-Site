
using System.ComponentModel.DataAnnotations;

namespace webCalculator.Models
{
    public class proddtaModel
    {


        [Key]
        public int ProdId { get; set; }
        public string ProdTitle { get; set; }
        public String ProdDescription { get; set; }
        public String ProdQuantity { get; set; }
        public String ProdBrand { get; set; }
        public string ProdCategory { get; set; }
        public decimal ProdPrice { get; set; }
    }
}
