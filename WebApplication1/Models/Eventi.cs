using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Eventi
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public DateOnly Data { get; set; }

    public string? Luogo { get; set; }

    public string? Tipologia { get; set; }

    public bool? Omologato { get; set; }

    public int? Costo { get; set; }

    public string LinkBando { get; set; } = null!;

    public string? Classifica { get; set; }

    public virtual ICollection<Lavoratori> FkidLavoratores { get; set; } = new List<Lavoratori>();

    public virtual ICollection<Partecipanti> FkidPartecipantes { get; set; } = new List<Partecipanti>();

    public virtual ICollection<Poli> FkidPolos { get; set; } = new List<Poli>();
}
