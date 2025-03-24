using System;
using System.Collections.Generic;

namespace SistemaVenta.MODEL;

public partial class Sale
{
    public int SaleId { get; set; }

    public string? DocumentNumber { get; set; }

    public string? PaymentType { get; set; }

    public decimal? Total { get; set; }

    public DateTime? DateRecord { get; set; }

    public virtual ICollection<SaleDetail> SaleDetails { get; set; } = new List<SaleDetail>();
}
