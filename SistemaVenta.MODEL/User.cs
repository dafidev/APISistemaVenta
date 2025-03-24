using System;
using System.Collections.Generic;

namespace SistemaVenta.MODEL;

public partial class User
{
    public int UserId { get; set; }

    public string? FullName { get; set; }

    public string? Email { get; set; }

    public int? RoleId { get; set; }

    public string? Key { get; set; }

    public bool? Enabled { get; set; }

    public DateTime? DateRecord { get; set; }

    public virtual Role? Role { get; set; }
}
