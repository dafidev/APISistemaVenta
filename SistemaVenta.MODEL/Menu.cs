﻿using System;
using System.Collections.Generic;

namespace SistemaVenta.MODEL;

public partial class Menu
{
    public int MenuId { get; set; }

    public string? Name { get; set; }

    public string? Icon { get; set; }

    public string? Url { get; set; }

    public virtual ICollection<MenuRole> MenuRoles { get; set; } = new List<MenuRole>();
}
