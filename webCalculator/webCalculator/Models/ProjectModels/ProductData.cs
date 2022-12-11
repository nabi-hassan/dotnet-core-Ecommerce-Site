using System;
using System.Collections.Generic;

namespace webCalculator.Models.ProjectModels;

public partial class ProductData
{
    public int ProdId { get; set; }

    public string? ProdTitle { get; set; }

    public string? ProdDescription { get; set; }

    public int? ProdQuantity { get; set; }

    public string? ProdBrand { get; set; }

    public string? ProdCategory { get; set; }

    public decimal? ProdPrice { get; set; }
}
