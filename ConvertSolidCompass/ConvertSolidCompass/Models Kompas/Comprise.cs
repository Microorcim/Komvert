using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Comprise
{
    public int Id { get; set; }

    public string RecordId { get; set; } = null!;

    public string Pos { get; set; } = null!;

    public string? Group { get; set; }

    public string? Name { get; set; }

    public string? Gost { get; set; }

    public int Quantity { get; set; }

    public string? Notes { get; set; }

    public virtual Record Record { get; set; } = null!;
}
