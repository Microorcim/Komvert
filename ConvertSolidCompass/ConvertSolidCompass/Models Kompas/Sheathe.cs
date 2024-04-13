using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Sheathe
{
    public string Id { get; set; } = null!;

    public string RecordId { get; set; } = null!;

    public double InternalX { get; set; }

    public double InternalY { get; set; }

    public double InternalDiameter { get; set; }

    public double ExternalX { get; set; }

    public double ExternalY { get; set; }

    public double ExternalDiameter { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual Record Record { get; set; } = null!;
}
