using System;
using System.Collections.Generic;

namespace AvaloniaApplication22.Models;

public partial class Tovar
{
    public int Id { get; set; }

    public string Article { get; set; } = null!;

    public int TovarNameId { get; set; }

    public int UnitId { get; set; }

    public int Price { get; set; }

    public int MaxDiscount { get; set; }

    public int ManufacturerId { get; set; }

    public int SupplierId { get; set; }

    public int CategoryId { get; set; }

    public int CurrentDiscount { get; set; }

    public int Quantity { get; set; }

    public string Description { get; set; } = null!;

    public string? ImageName { get; set; }

    public int? TovarId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Manufacturer Manufacturer { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual TovarNaming TovarName { get; set; } = null!;

    public virtual Unit Unit { get; set; } = null!;
}
