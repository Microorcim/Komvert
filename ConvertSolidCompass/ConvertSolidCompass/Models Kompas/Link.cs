using System;
using System.Collections.Generic;

namespace ConvertSolidCompass;

public partial class Link
{
    public string Id { get; set; } = null!;

    public string RecordFromId { get; set; } = null!;

    public string ToId { get; set; } = null!;

    public short WhereTo { get; set; }

    public short Quantity { get; set; }

    public virtual Record RecordFrom { get; set; } = null!;
}
