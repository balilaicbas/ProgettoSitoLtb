﻿using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class PoloScuola
{
    public int FkidPolo { get; set; }

    public int FkidScuola { get; set; }

    public int Anno { get; set; }

    public virtual Poli FkidPoloNavigation { get; set; } = null!;

    public virtual Scuole FkidScuolaNavigation { get; set; } = null!;
}