using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Lug
{
    public string Id { get; set; } = null!;

    public string RecordId { get; set; } = null!;

    public short Type { get; set; }

    public double Diameter { get; set; }

    public double Section { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual Record Record { get; set; } = null!;
}
