using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class ModelReference
{
    public int Id { get; set; }

    public string RecordId { get; set; } = null!;

    public short Type { get; set; }

    public string Reference { get; set; } = null!;

    public virtual Record Record { get; set; } = null!;
}
