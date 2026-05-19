using System;
using System.Collections.Generic;

namespace AvaloniaApplication22.Models;

public partial class TovarNaming
{
    public int Id { get; set; }

    public string TovarName { get; set; } = null!;

    public virtual ICollection<Tovar> Tovars { get; set; } = new List<Tovar>();
}
