using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace webCalculator.Models;
public class ProductData
{
    [Key]
    public int ProdId { get; set; }

    public string? ProdTitle { get; set; }

    public string? ProdDescription { get; set; }

    public int? ProdQuantity { get; set; }

    public string? ProdBrand { get; set; }

    public string? ProdCategory { get; set; }

    public decimal? ProdPrice { get; set; }
}
