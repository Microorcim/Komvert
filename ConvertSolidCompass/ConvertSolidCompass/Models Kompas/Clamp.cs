using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Clamp
{
    public string Id { get; set; } = null!;

    public string PartId { get; set; } = null!;

    public string Number { get; set; } = null!;

    public double MaxSectionValue { get; set; }

    public short MaxConnectionNumber { get; set; }

    public short Wiring { get; set; }

    public double Diameter { get; set; }

    public short Lug { get; set; }

    public string? WireNumber { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual Part Part { get; set; } = null!;
}
