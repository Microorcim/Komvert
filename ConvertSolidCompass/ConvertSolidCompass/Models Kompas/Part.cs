using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Part
{
    public string Id { get; set; } = null!;

    public string? ApparatusId { get; set; }

    public string? Name { get; set; }

    public short? Type { get; set; }

    public string? Comment { get; set; }

    public virtual Apparatus? Apparatus { get; set; }

    public virtual ICollection<Clamp> Clamps { get; set; } = new List<Clamp>();
}
