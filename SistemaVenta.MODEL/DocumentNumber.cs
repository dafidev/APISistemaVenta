using System;
using System.Collections.Generic;

namespace SistemaVenta.MODEL;

public partial class DocumentNumber
{
    public int DocumentNumberId { get; set; }

    public int LastNumber { get; set; }

    public DateTime? DateRecord { get; set; }
}
