using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Fastener
{
    public string Id { get; set; } = null!;

    public string RecordId { get; set; } = null!;

    public double DiameterMin { get; set; }

    public double DiameterMax { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual ICollection<FastenerImage> FastenerImages { get; set; } = new List<FastenerImage>();

    public virtual Record Record { get; set; } = null!;
}
