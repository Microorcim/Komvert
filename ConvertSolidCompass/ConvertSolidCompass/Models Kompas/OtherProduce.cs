using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class OtherProduce
{
    public string Id { get; set; } = null!;

    public string RecordId { get; set; } = null!;

    public string? UgoReference { get; set; }

    public virtual Record Record { get; set; } = null!;

    public virtual Ugo? UgoReferenceNavigation { get; set; }
}
