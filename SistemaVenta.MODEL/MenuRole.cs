﻿using System;
using System.Collections.Generic;

namespace SistemaVenta.MODEL;

public partial class MenuRole
{
    public int MenuRoleId { get; set; }

    public int? MenuId { get; set; }

    public int? RoleId { get; set; }

    public virtual Menu? Menu { get; set; }

    public virtual Role? Role { get; set; }
}
