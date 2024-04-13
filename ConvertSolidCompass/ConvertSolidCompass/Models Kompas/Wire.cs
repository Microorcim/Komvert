using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Wire
{
    public int Id { get; set; }

    public string ContentId { get; set; } = null!;

    public int ColorId { get; set; }

    public double Section { get; set; }

    public double ExternalDiameter { get; set; }

    public int MaterialId { get; set; }

    public short Coax { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual Color Color { get; set; } = null!;

    public virtual Cablecontent Content { get; set; } = null!;

    public virtual Material Material { get; set; } = null!;
}
