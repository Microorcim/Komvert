using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class FastenerImage
{
    public int Id { get; set; }

    public string FastenerId { get; set; } = null!;

    public string? UgoReference { get; set; }

    public virtual Fastener Fastener { get; set; } = null!;

    public virtual Ugo? UgoReferenceNavigation { get; set; }
}
