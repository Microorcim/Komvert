using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Cable
{
    public string Id { get; set; } = null!;

    public string RecordId { get; set; } = null!;

    public double Diameter { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual ICollection<Cablecontent> Cablecontents { get; set; } = new List<Cablecontent>();

    public virtual Record Record { get; set; } = null!;
}
