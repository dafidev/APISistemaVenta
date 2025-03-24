using System;
using System.Collections.Generic;

namespace SistemaVenta.MODEL;

public partial class Category
{
    public int CategoryId { get; set; }

    public string? Name { get; set; }

    public bool? Enabled { get; set; }

    public DateTime? DateRecord { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
