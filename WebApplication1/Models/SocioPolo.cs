using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SocioPolo
{
    public int FkidPolo { get; set; }

    public int FkidSocio { get; set; }

    public int Anno { get; set; }

    public virtual Poli FkidPoloNavigation { get; set; } = null!;

    public virtual Soci FkidSocioNavigation { get; set; } = null!;
}
