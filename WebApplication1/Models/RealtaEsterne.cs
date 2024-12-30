using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class RealtaEsterne
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Tipologia { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Cooperazioni> Cooperazionis { get; set; } = new List<Cooperazioni>();

    public virtual ICollection<RealtaEsternaPersona> RealtaEsternaPersonas { get; set; } = new List<RealtaEsternaPersona>();
}
