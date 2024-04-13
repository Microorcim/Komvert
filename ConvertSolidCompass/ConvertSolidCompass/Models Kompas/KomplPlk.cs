using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class KomplPlk
{
    public string Id { get; set; } = null!;

    public string RecordId { get; set; } = null!;

    public string? Typemdl { get; set; }

    public short? Selected { get; set; }

    public int? Quantity { get; set; }
}
