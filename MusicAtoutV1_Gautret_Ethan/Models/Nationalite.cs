using System;
using System.Collections.Generic;

namespace MusicAtoutV1_Gautret.Models;

public partial class Nationalite
{
    public int IdNation { get; set; }

    public string? LibNation { get; set; }

    public virtual ICollection<Compositeur> Compositeurs { get; set; } = new List<Compositeur>();
}
