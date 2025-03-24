using System;
using System.Collections.Generic;

namespace SistemaVenta.MODEL;

public partial class Product
{
    public int ProductId { get; set; }

    public string? Name { get; set; }

    public int? CategoryId { get; set; }

    public int? Stock { get; set; }

    public decimal? Price { get; set; }

    public bool? Enabled { get; set; }

    public DateTime? DateRecord { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<SaleDetail> SaleDetails { get; set; } = new List<SaleDetail>();
}
