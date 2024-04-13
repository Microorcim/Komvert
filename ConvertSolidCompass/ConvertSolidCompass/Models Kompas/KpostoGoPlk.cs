using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class KpostoGoPlk
{
    public string Id { get; set; } = null!;

    public string KposId { get; set; } = null!;

    public int GoId { get; set; }

    public string ModelId { get; set; } = null!;

    public byte? Type { get; set; }

    public int? Addaddr { get; set; }

    public string? KodGo { get; set; }

    public virtual GoElementsPlk Go { get; set; } = null!;

    public virtual KposPlk Kpos { get; set; } = null!;

    public virtual ModelsPlk Model { get; set; } = null!;
}
