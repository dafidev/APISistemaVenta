using System;
using System.Collections.Generic;

namespace SistemaVenta.MODEL;

public partial class Role
{
    public int RoleId { get; set; }

    public string? Name { get; set; }

    public DateTime? DateRecord { get; set; }

    public virtual ICollection<MenuRole> MenuRoles { get; set; } = new List<MenuRole>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
