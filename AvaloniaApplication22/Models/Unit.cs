using System;
using System.Collections.Generic;

namespace AvaloniaApplication22.Models;

public partial class Unit
{
    public int Id { get; set; }

    public string UnitName { get; set; } = null!;

    public virtual ICollection<Tovar> Tovars { get; set; } = new List<Tovar>();
}
