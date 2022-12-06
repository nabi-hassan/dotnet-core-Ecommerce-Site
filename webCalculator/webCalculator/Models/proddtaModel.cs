
using System.ComponentModel.DataAnnotations;

namespace webCalculator.Models
{
    public class proddtaModel
    {


        [Key]
        public int ProdId { get; set; }
        public string ProdTitle { get; set; }
        public string ProdDescription { get; set; }
        public string ProdQuantity { get; set; }
        public string ProdBrand { get; set; }
        public string ProdCategory { get; set; }
        public decimal ProdPrice { get; set; }
    }
}
