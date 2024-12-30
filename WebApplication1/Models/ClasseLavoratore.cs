using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class ClasseLavoratore
{
    public int FkidClasse { get; set; }

    public int FkidLavoratore { get; set; }

    public DateOnly Anno { get; set; }

    public virtual Classi FkidClasseNavigation { get; set; } = null!;

    public virtual Lavoratori FkidLavoratoreNavigation { get; set; } = null!;
}
